var sirina = 500;
var visina = 500;
var redovi = 20;
var kolone = 20;
var kvadratic = sirina / kolone;
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

function nacrtajMatricu(ctx, matrica){
    // Farbam ceo kavnas crno
    ctx.fillStyle = "black";
    ctx.fillRect(0, 0, sirina, visina);

    // Farbanje kvadrat po kvadrat
    ctx.fillStyle = "white";
    for(let i = 0; i < redovi; i++){
        for(let j = 0; j < kolone; j++){
            if(matrica[i][j] == 1){
                let y = i * kvadratic;
                let x = j * kvadratic;
                ctx.fillRect(x+1, y+1, kvadratic-2, kvadratic-2);
            }

        }
    }
}

function napravi2DNiz(brRedova, brKolona){
    let matrica = new Array(brRedova);
    for(let i = 0; i < brRedova; i++){
        matrica[i] = new Array(brKolona);
    }
    return matrica;
}

function napraviNasumicnuIgru(matrica){
    for(let i = 0; i < redovi; i++){
        for(let j = 0; j < kolone; j++){
            matrica[i][j] = Math.floor(Math.random()*1000) % 2;
        }
    }
    return matrica;
}

function prebrojKomsije(matrica, x, y){
    let brZivihKomsija = 0;
    // Cvrste ivice
    // for(let p = -1; p <= 1; p++){
    //     for(let q = -1; q <= 1; q++){
    //         if(x+p > -1 && y+q> -1 && x+p < redovi && y+q < kolone)
    //             brZivihKomsija += matrica[x+p][y+q];
    //     }
    // }
    
    // Spojene ivice
    for(let p = -1; p <= 1; p++){
        for(let q = -1; q <= 1; q++){
            let red = (x + p + redovi) % redovi;
            let col = (y + q + kolone) % kolone;
            brZivihKomsija += matrica[red][col];
        }
    }
    
    brZivihKomsija -= matrica[x][y];
    return brZivihKomsija;


}

function novaGeneracija(staraGen){
    let novaGen = napravi2DNiz(redovi, kolone);
    for(let i = 0; i < redovi; i++){
        for(let j = 0; j < kolone; j++){
            let brKomsija = prebrojKomsije(staraGen, i, j);
            let trenutnaCelija = staraGen[i][j];

            // Trenutna celija je mrtva, ali ima 3 ziva suseda
            // Postaje ziva u sledecoj generaciji 
            if(trenutnaCelija == 0 && brKomsija == 3){
                novaGen[i][j] = 1;
            } 
            // Trentuna ziva, i ima 2 ili 3 ziva suseda, prezivljava
            // u sledecu generaciju
            else if (trenutnaCelija == 1 && (brKomsija == 2 || brKomsija == 3)){
                novaGen[i][j] = 1;
            } 
            // Preostali slucajevi
            else {
                novaGen[i][j] = 0;
            }
        }
    }

    return novaGen;
}

function glavnaPetlja(igra){
    nacrtajMatricu(ctx, igra);
    igra = novaGeneracija(igra);
    return igra;
}


function main(){
    ctx = napraviKanvas(500, 500);
    let igra = napravi2DNiz(redovi, kolone);
    igra = napraviNasumicnuIgru(igra);
    setInterval(function(){igra = glavnaPetlja(igra)}, 100);
    

}

document.addEventListener("DOMContentLoaded", main);