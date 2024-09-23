const maxAttempts = 6;
let attemptsLeft = maxAttempts;
const correctNumber = Math.floor(Math.random() * 40) + 1;

console.log(correctNumber);

const buttonsContainer = document.getElementById('buttons-container');
for (let i = 1; i <= 40; i++) {
    const button = document.createElement('button');
    button.textContent = i;
    button.classList.add('btn', 'btn-primary', 'btn-number', 'border', 'border-dark', 'fs-3');
    button.addEventListener('click', () => handleGuess(i, button));
    buttonsContainer.appendChild(button);
}


function handleGuess(guess, button) {
    if (attemptsLeft > 0) {
        attemptsLeft--;
        document.getElementById('attempts-left').textContent = attemptsLeft;

        if (guess === correctNumber) {
            button.classList.remove('btn-primary');
            button.classList.add('btn-success');
            console.log(1);


            disableAllButtons();

            setTimeout(() => {
                document.getElementById('completionModalLabel').textContent = "Congratulations You Won!"
                document.getElementById('modal-message').textContent = 'You guessed the correct number!';
                document.getElementById('attempts-used').textContent = maxAttempts - attemptsLeft;
                var myModal = new bootstrap.Modal(document.getElementById('completionModal'));
                myModal.show();
            }, 1000);

            setTimeout(() => window.location.href = "./start.html", 10000);
            return;
        }

        if (attemptsLeft === 0 && guess !== correctNumber) {

            disableAllButtons();
            setTimeout(() => {
                document.getElementById('modal-message').textContent = 'You ran out of attempts!';
                document.getElementById('attempts-used').textContent = maxAttempts;
                var myModal = new bootstrap.Modal(document.getElementById('completionModal'));
                myModal.show();
            }, 1000);
            setTimeout(() => window.location.href = "./start.html", 10000);
        }

        if (guess < correctNumber) {
            console.log(2);

            button.classList.remove('btn-primary');
            button.classList.add('btn-warning');
            return;
        }

        if (guess > correctNumber) {
            console.log(3);

            button.classList.remove('btn-primary');
            button.classList.add('btn-danger');
            return;
        }

    }
}

function disableAllButtons() {
    const buttons = document.querySelectorAll('.btn-number');
    buttons.forEach(button => button.disabled = true);
}


const startAgain = document.querySelector('#start-again');
startAgain.addEventListener('click', () => window.location.href = "./start.html")
