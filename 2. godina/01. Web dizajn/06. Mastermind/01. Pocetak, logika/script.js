let kombinacija = [0, 0, 0, 0];
let pokusaj = [3, 2, 6, 6];
let crni = 0;
let beli = 0;
let probrojavanje = [0, 0, 0, 0, 0, 0];
// 1  2  3  4  5  6
let niz_crnih = [0, 0, 0, 0];

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

// Stavljamo event listener na dugme

document
  .getElementById("nova-kombinacija")
  .addEventListener("click", function novaKombinacija() {
    // Pravi novu kombinaciju
    for (i = 0; i < 4; i++) {
      kombinacija[i] = Math.floor(((Math.random() * 1000) % 6) + 1);
    }
    // Ocenjuje za trenutni pokusaj
    oceni(kombinacija, pokusaj);
  });
