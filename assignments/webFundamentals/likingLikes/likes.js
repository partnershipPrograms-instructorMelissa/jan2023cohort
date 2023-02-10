var likes = [9, 12, 9];
var span = [
    document.querySelector("#post1"),
    document.querySelector("#post2"),
    document.querySelector("#post3")
];

function like(id) {
    likes[id]++;
    span[id].innerHTML = likes[id] + " like(s)";
}