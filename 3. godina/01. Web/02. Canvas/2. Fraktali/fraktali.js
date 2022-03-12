var htmlCanvas = document.getElementById("kanvas_fraktal");
var cetkica = htmlCanvas.getContext("2d");
cetkica.fillStyle = "black";

function crtaj(pocetnoX, pocetnoY, duzina, ugao){
    cetkica.beginPath();
    cetkica.save();
    cetkica.translate(pocetnoX, pocetnoY);
    let rad_ugao = ugao * Math.PI / 180;
    cetkica.rotate(rad_ugao);
    cetkica.moveTo(0, 0);
    cetkica.lineTo(0, -duzina);
    cetkica.stroke();

    if(duzina < 3){
        cetkica.restore();
        return;
    }

    crtaj(0, -duzina, duzina*0.5, -120);
    crtaj(0, -duzina, duzina*0.5, 0);
    crtaj(0, -duzina, duzina*0.5, 120);
    cetkica.restore();
}

function main(){
    crtaj(400, 400, 200, 0);
}

document.addEventListener("DOMContentLoaded", main);
