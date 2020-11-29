let kombinacija = [0, 0, 0, 0];
let pokusaj = [3, 2, 6, 6];
let crni = 0;
let beli = 0;
let probrojavanje = [0, 0, 0, 0, 0, 0];
// 1  2  3  4  5  6
let niz_crnih = [0, 0, 0, 0];

let dugme_1 = document.getElementById("dgm_p1");
let dugme_2 = document.getElementById("dgm_p2");
let dugme_3 = document.getElementById("dgm_p3");
let dugme_4 = document.getElementById("dgm_p4");
dugme_1.addEventListener("click", promena1);
dugme_2.addEventListener("click", promena2);
dugme_3.addEventListener("click", promena3);
dugme_4.addEventListener("click", promena4);
function promena1(){ promena(1); }
function promena2(){ promena(2); }
function promena3(){ promena(3); }
function promena4(){ promena(4); }


function promena(k){
  let dgm = document.getElementById("dgm_p" + k);

  pokusaj[k - 1]++;
  if(pokusaj[k - 1] > 6){
    pokusaj[k - 1] = 1;
  }

  switch(pokusaj[k - 1]){
    case 1: dgm.style.background = "#ff7777"; break;
    case 2: dgm.style.background = "#ffff77"; break;
    case 3: dgm.style.background = "#7777ff"; break;
    case 4: dgm.style.background = "#77ff77"; break;
    case 5: dgm.style.background = "#ffaa44"; break;
    case 6: dgm.style.background = "#ff77ff"; break;
    default: break;
  }
  console.log(pokusaj);

}

function oceni(kombinacija, pokusaj) {
  crni = 0; // Dobar broj, dobro mesto
  beli = 0; // Dobar broj
  let niz_crnih = [0, 0, 0, 0];

  // // Pro
  // Kombinacija 1 1 2 4
  // pokusaj     3 3 3 1

  // Pronalazenje crnih i potencijalnih belih pogodaka
  for (i = 0; i < 4; i++) {
    if (kombinacija[i] == pokusaj[i]) {
      niz_crnih[i] = 1;
      crni++; // crni += 1;
    } else {
      probrojavanje[kombinacija[i] - 1]++;
    }
  }

  // Pronalazenje belih pogodaka
  for (i = 0; i < 4; i++) {
    // Beli pogodak je beli, ako nije crni i ako postoji potencijalni beli,
    // ako je u kombinaciji nadjen ne crni pogodak i pokusaj u tom trenutku
    // odgovara potencijalnom belom iz kombinacije
    if (niz_crnih[i] == 0 && probrojavanje[pokusaj[i] - 1] > 0) {
      beli++;
      probrojavanje[pokusaj[i] - 1]--;
    }
  }

  ispisi();
}

function ispisi() {
  // Kombinacija
  document.getElementById("kombinacija").innerHTML = "Kombinacija: ";
  for (i = 0; i < 4; i++) {
    document.getElementById("kombinacija").innerHTML += kombinacija[i];
  }
  // Pokusaj
  document.getElementById("pokusaj").innerHTML = "Pokusaj: ";
  for (i = 0; i < 4; i++) {
    document.getElementById("pokusaj").innerHTML += pokusaj[i];
  }

  // Crni i Beli
  document.getElementById("crni").innerHTML = "Crni: " + crni;
  document.getElementById("beli").innerHTML = "Beli: " + beli;
}


function novaKombinacija() {
  // Pravi novu kombinaciju
  for (i = 0; i < 4; i++) {
    kombinacija[i] = Math.floor(((Math.random() * 1000) % 6) + 1);
    let dgm = document.getElementById("dgm_k" + (i+1));

    switch(kombinacija[i]){
      case 1: dgm.style.background = "#ff7777"; break;
      case 2: dgm.style.background = "#ffff77"; break;
      case 3: dgm.style.background = "#7777ff"; break;
      case 4: dgm.style.background = "#77ff77"; break;
      case 5: dgm.style.background = "#ffaa44"; break;
      case 6: dgm.style.background = "#ff77ff"; break;
      default: break;
    }
  }
  // Ocenjuje za trenutni pokusaj
  oceni(kombinacija, pokusaj);
}

// Stavljamo event listener na dugme
document.getElementById("nova-kombinacija").addEventListener("click", novaKombinacija);
