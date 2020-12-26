const vreme = document.getElementById("timer");
const nova_godina = new Date(2021, 0, 1, 0, 0, 0, 0).getTime();

function dohvatiTrenutnoVreme(){
    let trenutno_vreme = new Date().getTime();
    let do_nove_godine = nova_godina - trenutno_vreme; // u milisekundama

    // Stigli smo do nove godine!
    if(do_nove_godine <= 0){
        vreme.innerHTML = "SREĆNA NOVA 2021. GODINA!"
        clearInterval(timer_interval);
        return
    }

    // Izracunavamo dane, sate, minute, sekunde
    let dani = Math.floor(do_nove_godine / (1000 * 60 * 60 * 24));
    let sati = Math.floor((do_nove_godine % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    let minuti = Math.floor((do_nove_godine % (1000 * 60 * 60)) / (1000 * 60));
    let sekundi = Math.floor((do_nove_godine % (1000 * 60)) / 1000);
    
    // Ispis u paragraf
    vreme.innerHTML = dani + "d " + sati + "h " + minuti + "m " + sekundi + "s";

}

// Pozivamo funkciju jednom da se izvrsi pri ucitavanju stranice i postavljamo interval za izvrsavanje
dohvatiTrenutnoVreme();
const timer_interval = setInterval(dohvatiTrenutnoVreme, 1000);

function kreniProgress(){
    const step = document.getElementById("progress-step")
    let width = 0;
    let step_interval = setInterval(progressStep, 1000);
    function progressStep(){
        if (width == 100){
            clearInterval(step_interval);
        } else {
            width++;
            step.style.width = width + "%";
            console.log(width);
        }
    }
}

