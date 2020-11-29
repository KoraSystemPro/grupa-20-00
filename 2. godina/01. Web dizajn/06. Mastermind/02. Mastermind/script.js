let kombinacija = [0, 0, 0, 0];
let pokusaj = [0, 0, 0, 0];
let crni = 0;
let beli = 0;
let prebrojavanje = [0, 0, 0, 0, 0, 0];
//                   1  2  3  4  5  6
let niz_crnih = [0, 0, 0, 0];

let dugme_1 = document.getElementById("dgm_p1");
let dugme_2 = document.getElementById("dgm_p2");
let dugme_3 = document.getElementById("dgm_p3");
let dugme_4 = document.getElementById("dgm_p4");
dugme_1.addEventListener("click", promena1);
dugme_2.addEventListener("click", promena2);
dugme_3.addEventListener("click", promena3);
dugme_4.addEventListener("click", promena4);
function promena1(){ promena("p", 1); }
function promena2(){ promena("p", 2); }
function promena3(){ promena("p", 3); }
function promena4(){ promena("p", 4); }


function promena(tip, k){
  let dgm = document.getElementById("dgm_" + tip + k);

  if(tip == "p"){
    // Slucaj za dugmice za pokusaj
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
      default: dgm.style.background = "#777777"; break;
    }
  } else {
    // Slucaj za ispis pocetne kombinacije
    switch(kombinacija[k - 1]){
      case 1: dgm.style.background = "#ff7777"; break;
      case 2: dgm.style.background = "#ffff77"; break;
      case 3: dgm.style.background = "#7777ff"; break;
      case 4: dgm.style.background = "#77ff77"; break;
      case 5: dgm.style.background = "#ffaa44"; break;
      case 6: dgm.style.background = "#ff77ff"; break;
      default: dgm.style.background = "#777777"; break;
    }
  }

}

function oceni(kombinacija, pokusaj) {
  crni = 0; // Dobar broj, dobro mesto
  beli = 0; // Dobar broj
  niz_crnih = [0, 0, 0, 0];
  prebrojavanje = [0, 0, 0, 0, 0, 0];

  // Pronalazenje crnih i potencijalnih belih pogodaka
  for (i = 0; i < 4; i++) {
    if (kombinacija[i] == pokusaj[i]) {
      niz_crnih[i] = 1;
      crni++; // crni += 1;
    } else {
      prebrojavanje[kombinacija[i] - 1]++;
    }
  }

  // Pronalazenje belih pogodaka
  for (i = 0; i < 4; i++) {
    // Beli pogodak je beli, ako nije crni i ako postoji potencijalni beli,
    // ako je u kombinaciji nadjen ne crni pogodak i pokusaj u tom trenutku
    // odgovara potencijalnom belom iz kombinacije
    if (niz_crnih[i] == 0 && prebrojavanje[pokusaj[i] - 1] > 0) {
      beli++;
      prebrojavanje[pokusaj[i] - 1]--;
    }
  }

  // Dobitni pogodak, pokazuje resenu kombinaciju
  if(crni == 4){
    document.getElementById("sakriven_red").style.display = "flex";
  }

  console.log("Kombinacija: " + kombinacija + "\n" + "Pokusaj: " + pokusaj);


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
  // Pravi novu kombinaciju i sakriva prethodnu dobitnu
  document.getElementById("sakriven_red").style.display = "none";
  for (i = 1; i < 5; i++){
    document.getElementById("dgm_p" + i).style.background = "#777777";
  }

  for (i = 0; i < 4; i++) {
    kombinacija[i] = Math.floor(((Math.random() * 1000) % 6) + 1);
    promena("k", i+1);
  }
}

// Stavljamo event listener na dugme
document.getElementById("nova-kombinacija").addEventListener("click", novaKombinacija);
document.getElementById("oceni").addEventListener("click", function(){ oceni(kombinacija, pokusaj) });
