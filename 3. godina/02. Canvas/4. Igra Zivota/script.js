var sirina = 500;
var visina = 500;
var kvadratic = 50;
var ctx;

function napraviKanvas(width, height){
    let canvas = document.createElement("canvas");
    canvas.id = "platno";
    canvas.width = width;
    canvas.height = height;

    document.body.appendChild(canvas);
    let ctx = canvas.getContext("2d");
    return ctx;
}

function nacrtajMatricu(ctx){
    // Farbam ceo kavnas crno
    ctx.fillStyle = "black";
    ctx.fillRect(0, 0, sirina, visina);

    // Farbanje kvadrat po kvadrat
    ctx.fillStyle = "white";
    for(let i = 0; i < 10; i++){
        for(let j = 0; j < 10; j++){
            let y = i * kvadratic;
            let x = j * kvadratic;

            ctx.fillRect(x+1, y+1, kvadratic-2, kvadratic-2);

        }
    }
}

function main(){
    ctx = napraviKanvas(500, 500);
    nacrtajMatricu(ctx);

}

document.addEventListener("DOMContentLoaded", main);