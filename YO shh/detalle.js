const alternatives = [
    {text:"", images:"images/1.png"},
    {text:"Te prometo que será inolvidable", images:"images/2.png"},
    {text:"Piénsalo de nuevo", images:"images/3.png"},
    {text:"Vamos, atrévete a decir que sí", images:"images/4.png"},
    {text:"Que el miedo no te detenga", images:"images/MyF(2).png"}
];
const ohyes = {text:"Sabía que aceptarías", images:"images/MyF(xD).png", images: "images/MyF(gato).png"};
const title = document.querySelector('.title');
const text = document.querySelector('.text');
const cat = document.querySelector('.cat');
const buttons = document.querySelectorAll('.button');
const errorButton = document.querySelector('.button__error');

let count = 0;
function updateDisplay(item) {
    console.log(item);
    cat.src = item.images;
    text.innerHTML = item.text;
}

errorButton.addEventListener('click', () => {
    count = 0;
    updateDisplay(alternatives[count]);
    buttons.forEach(btn => btn.style.display = 'inline-block');
    errorButton.style.display = 'none';
});

buttons.forEach(button => {
    button.addEventListener('click', () => {
        if(button.textContent === 'SÍ'){
            updateDisplay(ohyes);
            buttons.forEach(btn => btn.style.display = 'none');
        }
        if (button.textContent === 'NO'){
            count++;
            if(count < alternatives.length){
                updateDisplay(alternatives[count]);
            } else {
                buttons.forEach(btn => btn.style.display = 'none');
                errorButton.style.display = 'inline-block';
            }
        }
    });
});