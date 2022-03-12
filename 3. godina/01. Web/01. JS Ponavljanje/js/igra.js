var i = 0;

function uradi() {
    slika.src = (++i % 3) + ".jpg";
}

function ispisi() {
    console.log("Ovo radi!");
    let slika = document.getElementById("slika");
    slika.addEventListener("click", uradi);
}


document.addEventListener("DOMContentLoaded", ispisi);