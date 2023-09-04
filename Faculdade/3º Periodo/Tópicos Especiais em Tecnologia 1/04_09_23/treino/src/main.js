const express = require('express');

const app = express();

//Rota principal... (usar o .get para definir rotas...)
app.get('/',function(request, response){ 
    response.send('API Funcionando...',);
});

app.get('/sobre', function(request, response){
    response.json({mensagem:'Olá', autor: 'Wallan Oliveira', email: 'wallanoliveiradasilva@gmail.com', contato: '+55 69 992549998'})
})

//Iniciando a aplicaão na porta 3000
app.listen(3000,function(){
    console.log('API Iniciada na porta 3000');
});