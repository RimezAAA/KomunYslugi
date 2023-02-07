function saveAsFile(fileName, bytesBase64) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = 'data:application/pdf;base64,' + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

var Email;
var recipient_id;
var sender_id;
function openForm(email, recipient, sender) {
    document.getElementById("myForm").style.display = "block";
    Email = email;
    recipient_id = recipient;
    sender_id = sender;
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
    document.getElementById("messages").innerHTML = "";
}

const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/chat")
    .build();

function Send() {
    const message = document.getElementById("msg").value;
    hubConnection.invoke("Send", message, Email, recipient_id, sender_id) // отправка данных серверу
        .catch(function (err) {
            return console.error(err.toString());
        });
}

hubConnection.on("Receive", function (message, userName, recipient, sender) {
    console.log(recipient_id + " " + recipient);
    console.log(sender_id + " " + sender);
    if (recipient_id == recipient && sender_id == sender) {
        // создаем элемент <b> для имени пользователя
        const userNameElem = document.createElement("b");
        userNameElem.textContent = `${userName}: `;

        // создает элемент <p> для сообщения пользователя
        const elem = document.createElement("p");
        elem.appendChild(userNameElem);
        elem.appendChild(document.createTextNode(message));

        // добавляем новый элемент в самое начало
        // для этого сначала получаем первый элемент
        const firstElem = document.getElementById("messages").firstChild;
        document.getElementById("messages").insertBefore(elem, firstElem);
    }
});

hubConnection.start()
    .then(function () {
        document.getElementById("sendBtn").disabled = false;
    })
    .catch(function (err) {
        return console.error(err.toString());
    });
