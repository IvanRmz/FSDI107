



function fetchTasks() {
    //create an aget ajax req /api/tasks
    //console log the response from the server
    $.ajax({
        url: "/api/tasks",
        type: "GET",
        success: tasks => {
            console.log(tasks);
            tasks.forEach(task => {
                displayTask(task);
            });
        },
        error: details => {
            console.log("Error getting data ", details);
        }
    });
}

function displayTask(task) {
    var container = $("#tasks");
    var syntax = `
        <div class="card task">
            <div class="card-body item-body">
                <div>
                    <i class="far fa-circle check ic-check"></i>
                </div>
                <div class="task-content">
                    <h5 class="task-title">${task.title}</h5>
                    <label class="task-notes">${task.notes}</label>
                </div>
                <div>
                    <i class="fas fa-star ic-star"></i>
                </div>
            </div>
        </div>
    `;
    container.append(syntax);
}

function register () {

    let inputTitle  = $("#txtTitle");
    let inputNotes  = $("#txtNotes");
    let inputImportant  = $("#chkImportant");
    // get values from the form
    let title =  inputTitle.val();
    let notes = inputNotes.val();
    let imp = inputImportant.is(":checked");

    // validations
    if(title.length < 5) {
        alert("Please verify the title");
        return;
    }

    // create an object
    let task = {
        title: title,
        notes: notes,
        important: imp
    };

    console.log(task);
    // send the object to BD
    $.ajax({
        type: "POST",
        url: "api/createTask",
        data: JSON.stringify(task),
        contentType: "application/json",
        success: function(res) {
            console.log("Server says " , res);
            displayTask(task);
        },
        error: function (details) {
            console.log("Error: ", details);
        }

    });

    // clear the form
    inputTitle.val("");
    inputNotes.val("");

}

function init() {
    console.log("My Calendar Page");


    $("#btnSave").click(register);


    fetchTasks();
}

window.onload = init;