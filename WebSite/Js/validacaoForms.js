function validar() {

    if (document.frmCadAluno.txtMatricula.value == "" ) {
        document.frmCadAluno.txtMatricula.focus();
        alert("Preencha o campo obrigatório:MATRICULA");
        return false;
    }
    
    if (document.frmCadAluno.txtCPF.value == "" ) {
        document.frmCadAluno.txtCPF.focus();
        alert("Preencha o campo obrigatório: CPF");
        return false;
    }
    
    
    
    return true;

}

function validarEditora() {


    if (document.frmCadEditora.txtNomeEditora.value == "" ) {
        document.frmCadEditora.txtNomeEditora.focus();
        alert("Preencha o campo obrigatório:NOME DA EDITORA");
        return false;

    }

    if (document.frmCadEditora.txtLocal.value =="") {
        document.frmCadEditora.txtLocal.focus();
        alert(" Preencha o campo obrigatório: LOCAL ");
        return false;
    }
   

    return true;

}


function validarAutor() {

    if (document.frmCadAutor.txtNome.value == "" ) {
        
        document.frmCadAutor.txtNome.focus();
        alert("Preencher campo obrigatório: NOME DO AUTOR ");
        return false;
    }

    if (!document.getElementsById("rbMasculino").checked) {
        alert("Preencher campo obrigatório: SEXO");
        return false;
    }
    
    if (!document.getElementsById("rbFeminino").checked) {
        alert("Preencher campo obrigatório: SEXO");
        return false;
    }

    return true;

}