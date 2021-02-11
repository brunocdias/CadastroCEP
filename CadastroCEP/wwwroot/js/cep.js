jQuery(function ($) {
    $("input[name='Cep']").change(function () {
        var cep = $(this).val();
        if (cep.length <= 0) {
            swal("Digite um cep válido!");
        }
        else {
            $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                if (!("erro" in dados)) {
                    //Atualiza os campos com os valores da consulta.
                    $("input[name=Estado]").val(dados.uf);
                    $("input[name=Cidade]").val(dados.localidade);
                    $("input[name=Bairro]").val(dados.bairro);
                    $("input[name=Endereco]").val(dados.logradouro);
                } else {
                    //CEP pesquisado não foi encontrado.                    
                    swal("CEP não encontrado.");
                }
            });
        }
    });
});