const express = require('express');

const app = express();

//Rota principal
app.get('/', function (request, response){
    return response.json({mensagem:"API Funcionando..."});
});

app.get('/sobre', function (request, response){
    const info = {
        autor: "Wallan",
        email: "wallanoliveiradasilva@gmail.com",
        telefone: "(69) 992549998"
    }

    return response.json(info);
});

//Iniciando a aplicação na porta 3000 (esse código fica sempre nas ultimas linhas)
app.listen(3000, function (){
    console.log('API iniciada na porta: 3000');
});