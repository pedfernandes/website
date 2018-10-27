function notificaoDeletar() {

    

    if (confirm("Você deseja apagar este item? ")) {

        var xhttp = new XMLHttpRequest();

        

        xhttp.onreadystatechange = function () {
            if (xhttp.readyState == 4 && xhttp.status == 200) {


            }
        };
        xhttp.open("post", "~/View/Aluno/AlunosCadastrados.cshtml", true);
        xhttp.send();

       
    }
    else {
        
        alert(" teste funcionando!!! ");
    }

}