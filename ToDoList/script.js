let taskInput = document.getElementById("task-input");
let ul = document.getElementById("display-element");
let addButton = document.getElementById("btnn");

let taskArray = [];

addButton.addEventListener("click", () => 
{

    let taskName = taskInput.value.trim();

    if (taskName === "")
    {
        alert("Task Name cannot be Empty")
        return;
    }

    let existingTask = taskArray.find(task => task.taskName === taskName);

    if (!existingTask) {
        taskArray.push({ taskName, taskStatus: "false" });
        Display();
    } 
    else {
        alert("Task already exists.");
    }

    taskInput.value = "";
});

function Display() {
    ul.innerHTML = "";

    taskArray.forEach((task, index) => 
    {

        let li = document.createElement("li");
        li.innerText = task.taskName;
        li.classList.add("list-group-item");
        li.classList.add("todo-list-item");

        if (task.taskStatus === "true") {
            li.classList.add("strikethrough");
        }

        let div = document.createElement("div");
        div.classList.add("align-self-end");
        div.classList.add("ml-auto");

        let buttonSuccess = document.createElement("button");
        buttonSuccess.classList.add("action-button-success");

        let buttonDanger = document.createElement("button");
        buttonDanger.classList.add("action-button");

        if(task.taskStatus === "false")
        {
            let i1 = document.createElement("i");
            i1.classList.add("fas", "fa-check");
            buttonSuccess.appendChild(i1);
            div.appendChild(buttonSuccess);
        }

        let i2 = document.createElement("i");
        i2.classList.add("fas", "fa-times");
        buttonDanger.appendChild(i2);
        div.appendChild(buttonDanger);

        li.appendChild(div);
        ul.appendChild(li);

        buttonDanger.addEventListener("click", () => {
            taskArray.splice(index, 1);
            Display();
        });

        buttonSuccess.addEventListener("click", () => {
            task.taskStatus = "true";
            Display();
        });
    });
}
