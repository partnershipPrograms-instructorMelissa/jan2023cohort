//* PRINT ODD NUMBERS 1 - 255
for (let i = 1; i <= 255; i += 2) {
  console.log("odd numbers:", i);
}

for (let i = 1; i <= 255; i++) {
  if (i % 2 != 0) console.log("odd numbers:", i);
}
