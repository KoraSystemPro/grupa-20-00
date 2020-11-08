// console.log(5 + 8);
// console.log("Cao");

// let a = 18;
// let b = 22;
// console.log(a + b);

console.log(Math.random() * 1000);

function vrati_nausmicnu_vrednost() {
  let broj = Math.random();
  broj = Math.floor((broj * 1000) % 100);
  console.log(broj);
}
