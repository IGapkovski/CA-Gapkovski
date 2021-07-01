let addButton = document.getElementById("add-button");
addButton.addEventListener("click", addToDoItem);

function addToDoItem() {
    let itemText = toDoEntryBox.value;
    newToDoItem(itemText, false);
}

let clearComButton = document.getElementById("clear-completed-button");
clearComButton.addEventListener("click", clearCompleatedToDoItems);

function clearCompleatedToDoItems() {
    var completedItems = toDoList.getElementsByClassName("completed");

    while (completedItems.length > 0) {
        completedItems(0).remove (0);
    }
}

let emptyButton = document.getElementById("empty-button");
emptyButton.addEventListener("click", emptyList);

function emptyList() {
    var toDoItems = toDoList.children;
    while (toDoItems.length > 0) {
        toDoItems(0).remove (0);
    }
}

let saveButton = document.getElementById("save-button");
saveButton.addEventListener("click", saveList);

function saveList() {
    alert("List Saved!");
}

let toDoEntryBox = document.getElementById("todo-entry-box");
let toDoList = document.getElementById("todo-list");

function newToDoItem(itemText, completed){
    let toDoItem = document.createElement("li");
    let toDoText = document.createTextNode(itemText);
    toDoItem.appendChild(toDoText);
    if(completed){
        toDoItem.classList.add("completed");
    }
    toDoList.appendChild(toDoItem);
    toDoItem.addEventListener("dbclick", toggleToDoItemState);
}

function toggleToDoItemState (){
    if (this.classList.contains("completed")){
        this.classList.remove("completed");
    } else {
        this.classList.add("completed")
    }
}


