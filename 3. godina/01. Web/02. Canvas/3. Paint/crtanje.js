var platno = document.getElementById("platno");
var kontekst = platno.getContext("2d");
kontekst.strokeStyle = "#ff0000";
kontekst.lineJoin = "round";
kontekst.lineWidth = 5;

var klikoviX = [];
var klikoviY = [];
var klikVuce = [];
var pritisnutMis;
function dodajLeviKlik(x, y, vuce){
    klikoviX.push(x);
    klikoviY.push(y);
    klikVuce.push(vuce);
}

function crtaj(){
    var i = klikoviX.length - 1;
    if(!klikVuce[i]){
        if(klikoviX.length == 0){
            kontekst.beginPath();
            kontekst.moveTo(klikoviX[i], klikoviY[i]);
            kontekst.stroke();
        } else {
            kontekst.closePath();
    
            kontekst.beginPath();
            kontekst.moveTo(klikoviX[i], klikoviY[i]);
            kontekst.stroke();
        }
    } else {
        kontekst.lineTo(klikoviX[i], klikoviY[i]);
        kontekst.stroke();
    }
    

}

function mouseDownEvent(e){
    pritisnutMis = true;
    let x = e.pageX - platno.offsetLeft;
    let y = e.pageY - platno.offsetTop;

    if(pritisnutMis) {
        dodajLeviKlik(x, y, false);
        crtaj();
    }
}

function mouseUpEvent(e){
    pritisnutMis = false;
    kontekst.closePath();
}

function mouseMoveEvent(e){
    let x = e.pageX - platno.offsetLeft;
    let y = e.pageY - platno.offsetTop;

    if(pritisnutMis) {
        dodajLeviKlik(x, y, true);
        crtaj();
    }
}

platno.addEventListener("mousedown", mouseDownEvent);
platno.addEventListener("mouseup", mouseUpEvent);
platno.addEventListener("mousemove", mouseMoveEvent);
