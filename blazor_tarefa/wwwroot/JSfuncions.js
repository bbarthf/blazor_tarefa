﻿window.MostraAlerta = (message) => {

    alert(message);
}

function getTotalTarefas()
{
    DotNet.invokeMethodAsync
        ("blazor_tarefa", "ObterTotalTarefa")
        .then(resultado => {
            alert("Total de Tarefas:" + resultado);
        });
}