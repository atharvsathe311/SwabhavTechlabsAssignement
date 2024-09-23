let isEditMode = false;
let editPostId = null; 

async function fetchPosts() {
    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/posts');
       
        if (!response.ok) {
            throw new Error('Network response was not ok ' + response.statusText);
        }

        const data = await response.json();
        const postsTable = document.getElementById('postsTable');
        postsTable.innerHTML = '';

        data.forEach((post) => {
            createPostRow(post.id, post.userId, post.title, post.body);
        });

        // Update the record count
        document.getElementById('recordCount').textContent = data.length;
    } catch (error) {
        console.error('Error fetching posts:', error);
    }
}

function createPostRow(postId, userId, title, body) {
    const postsTable = document.getElementById('postsTable');
    const newRow = postsTable.insertRow();

    const cell1 = newRow.insertCell(0);
    const cell2 = newRow.insertCell(1);
    const cell3 = newRow.insertCell(2);
    const cell4 = newRow.insertCell(3);
    const cell5 = newRow.insertCell(4);
    const cell6 = newRow.insertCell(5);

    cell1.innerHTML = postId;
    cell2.innerHTML = userId;
    cell3.innerHTML = title;
    cell4.innerHTML = body;

    const updateButton = document.createElement('button');
    updateButton.textContent = 'Update';
    updateButton.className = 'btn btn-warning btn-sm';
    updateButton.addEventListener('click', () => loadPostForEdit(postId, userId, title, body));
    cell5.appendChild(updateButton);

    const deleteButton = document.createElement('button');
    deleteButton.textContent = 'Delete';
    deleteButton.className = 'btn btn-danger btn-sm';
    deleteButton.addEventListener('click', () => deletePost(newRow, postId));
    cell6.appendChild(deleteButton);
}

function deletePost(row, postId) {
    const postsTable = document.getElementById('postsTable');
    postsTable.deleteRow(row.rowIndex - 1);
    document.getElementById('recordCount').textContent = postsTable.rows.length; 
    alert('Post with ID ' + postId + ' has been deleted!');
}

function loadPostForEdit(postId, userId, title, body) {
    document.getElementById('userId').value = userId;
    document.getElementById('title').value = title;
    document.getElementById('body').value = body;

    isEditMode = true;  
    editPostId = postId;  

    document.querySelector('button[type="submit"]').textContent = 'Update Post';
}

document.getElementById('postForm').addEventListener('submit', function (e) {
    e.preventDefault();

    const userId = document.getElementById('userId').value;
    const title = document.getElementById('title').value;
    const body = document.getElementById('body').value;

    if (isEditMode) {

        const rowToUpdate = [...document.getElementById('postsTable').rows].find(row => row.cells[0].innerHTML == editPostId);
        
        if (rowToUpdate) {
            rowToUpdate.cells[1].innerHTML = userId;
            rowToUpdate.cells[2].innerHTML = title;
            rowToUpdate.cells[3].innerHTML = body;
        }

        isEditMode = false;
        editPostId = null;
        document.querySelector('button[type="submit"]').textContent = 'Submit';  // Change the button text back
    } else {
        const newId = document.getElementById('postsTable').rows.length + 1;
        createPostRow(newId, userId, title, body);
    }

    document.getElementById('recordCount').textContent = document.getElementById('postsTable').rows.length;

    document.getElementById('postForm').reset();
});

window.onload = fetchPosts;
