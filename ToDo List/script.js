let addButton = document.getElementById("add-button");
addButton.addEventListener("click", addToDoItem);
function addToDoItem() {
    alert("Add button clicked!");
}
let clearComButton = document.getElementById("clear-completed-button");
clearComButton.addEventListener("click", clearCompleatedToDoItems);
function clearCompleatedToDoItems() {
    alert("Clear Completed!");
}
let emptyButton = document.getElementById("empty-button");
emptyButton.addEventListener("click", emptyList);
function emptyList() {
    alert("Empty List!");
}
let saveButton = document.getElementById("save-button");
saveButton.addEventListener("click", saveList);
function saveList() {
    alert("List Saved!");
}

let toDoEntryBox = document.getElementById("todo-entry-toDoEntryBox");




