// Ovo je primer jednolinijskog komentara
/* 
    Ovo je komentar
    u vise linija
*/
// console.log(Date());

function ispis_trenutnog_vremena() {
  let vreme = new Date();
  let s = "";

  // Sati
  let p = vreme.getHours();
  p = p < 10 ? "0" + p : p;
  //   if (p < 10) {
  //     p = "0" + p;
  //   } else {
  //     p = p;
  //   }

  s += p + ":";

  // Minuti
  p = vreme.getMinutes();
  p = p < 10 ? "0" + p : p;
  s += p + ":";

  // Sekunde
  p = vreme.getSeconds();
  p = p < 10 ? "0" + p : p;
  s += p + ":";

  // Milisekunde
  p = vreme.getMilliseconds();
  //   p = p < 10 ? "0" + p : p;
  if (p < 10) {
    p = "00" + p;
  } else if (p < 100) {
    p = "0" + p;
  }

  s += p;

  console.log(s);
  document.getElementById("rezultati").style =
    "background: salmon; width: 100px; height: 50px";
  document.getElementById("rezultati").innerHTML = s;
}

let inputIme = document.getElementById("forma-ime");
let inputLozinka = document.getElementById("forma-lozinka");
let brDivova = document.getElementById("forma-br-divova");

function ProsledjivanjePodataka() {
  let ime = inputIme.value;
  let lozinka = inputLozinka.value;
  let brDiv = brDivova.value;

  document.getElementById("rezultati-2").innerHTML = "";
  for (let brojac = 1; brojac <= brDiv; brojac++) {
    document.getElementById("rezultati-2").innerHTML +=
      '<div class="lepi-div">\
      <div class="lepi-div-zaglavlje">\
        Lepi div ' +
      brojac +
      '</div>\
      <div class="lepi-div-tekst">\
        Tekst' +
      ime +
      "\
      </div>\
    </div>";
  }
}
