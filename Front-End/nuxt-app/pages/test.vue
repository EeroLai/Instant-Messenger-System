<template>
    <div>
        Test
    </div>
</template>

<script setup>
import * as signalR from "@microsoft/signalr";

let connection = new signalR.HubConnectionBuilder()
    .withUrl("https://localhost:7103/Hubs/ChatHub", {
        skipNegotiation: true,
        transport: signalR.HttpTransportType.WebSockets
    })
    .build();

connection.on("ReceiveMsg", data => {
    console.log(data);
});

connection.start()
    .then(() => connection.invoke("SendMessage", "Hello"));


</script>
