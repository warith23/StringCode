//let words = prompt("Enter sentence");
let words = 'AfricanJournal';

let a = words.substring(0, (words.length/2));
let b = words.substring(words.length/2);


var newA = '';
var newB = '';

for (let i = 0; i < a.length-1; i++) {

    if (i % 2 == 0) {
        newA += a[i];   
        newA += b[i];
    }   
}
newA+= a[a.length-1];
//console.log(newA);

for (let i = 0; i < b.length-1; i++) {

    if (i % 2 != 0) {
        newB += a[i];   
        newB += b[i];
    }   
}
newB+= b[b.length-1];
//console.log(newB);

let encode = newB.concat(newA);
console.log(encode);

let c = newA;
let d = newB;

var newC = '';
var newD = '';

for (let i = 0; i < c.length-1; i++) {
    if (i % 2 == 0) {
        newC += c[i]; 
        newC += d[i];                               
    }
}
newC+= c[c.length-1];

for (let i = 0; i < d.length-1; i++) {
    if (i % 2 != 0)
    {
        newD += c[i]; 
        newD += d[i];                               
    }
}
newD+= d[d.length-1];

let decode = newC.concat(newD);
console.log(decode);