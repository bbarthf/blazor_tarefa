window.MostraAlerta = (message) => {

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

function getTotalTarefasInstancia(dotnet) {
    return dotnet.invokeMethodAsync("ObterTarefasInstancia")
        .then(resultado => {
            alert("Total de tarefas instancia: " + resultado);
        });
}
