function init() {
    console.log("My Calendar Page");

    fetchTasks();
}

function fetchTasks() {
    //create an aget ajax req /api/tasks
    //console log the response from the server
    $.ajax({
        url: "http://localhost:7001/api/tasks",
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
        <div class="task">
            <i class="far fa-circle check"></i>
            <div class="task-content">
                <h5 class="task-title">${task.title}</h5>
                <label class="task-notes">${task.notes}</label>
            </div>
            <i class="fas fa-star"></i>
        </div>
    `;
    container.append(syntax);
}

window.onload = init;