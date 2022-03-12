// RGB (red, green, blue)
// 0-255, 0-255, 0-255
var resetButton = document.getElementById("reset");
resetButton.addEventListener("click", init);

var boje = [];
var brKvadrata = 6;


init();
function init(){
    reset();
    postaviKvadrate();
}

function postaviKvadrate(){
    let kvadrati = document.querySelectorAll(".kvadrat");
    // document.getElementsByClassName("kvadrat");

    for(let i = 0; i < kvadrati.length; i++){
        // Prolazimo kroz sve kvadrate
        kvadrati[i].style.backgroundColor = boje[i];

        // Postavljamo event listenere na kvadrate
        kvadrati[i].addEventListener("click", function(){
            // Dohvatamo boju pritisnutog kvadrata
            let klikuntaBoja = this.style.backgroundColor;

            // Poredimo boju sa izabranom
            if(klikuntaBoja == izabranaBoja){
                alert("Bravo!");
            } else {
                this.style.backgroundColor = "rgb(50, 50, 50)";
                
            }
        });
    }


}

function reset(){
    // Generismo nasumicne boje
    boje = generisiNasumicneBoje(brKvadrata);

    // Biramo boju koja se pogadja
    izabranaBoja = birajBoju();
    let kodBoja = document.getElementById("boja-kod");
    kodBoja.textContent = izabranaBoja;
}

function birajBoju(){
    let rand = Math.floor(Math.random() * brKvadrata);
    return boje[rand];
}

function generisiNasumicneBoje(num){
    let niz = [];
    for(let i = 0; i < num; i++){
        niz.push(nasumicnaBoja());
    }
    return niz;
}

function nasumicnaBoja(){
    let r = Math.floor(Math.random() * 256);
    let g = Math.floor(Math.random() * 256);
    let b = Math.floor(Math.random() * 256);
    return "rgb(" + r + ", " + g + ", " + b + ")";
}