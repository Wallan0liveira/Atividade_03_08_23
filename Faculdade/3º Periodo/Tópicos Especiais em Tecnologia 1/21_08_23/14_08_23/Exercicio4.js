function Exercicio4(tipo, litros){
    let valorTotal = 0;
    let valorTipoA = 1.9;
    let valorTipoG = 2.5;
    
    if( tipo == "G"){
        
        if(litros <= 20){
            valorTipoG = valorTipoG - (valorTipoG * 0.04);
            valorTotal = valorTipoG*litros;
        }else{
            valorTipoG = valorTipoG - (valorTipoG * 0.06);
            valorTotal = valorTipoG * litros;
        }
    }else if( tipo  == "A"){
        if(litros <= 20){
            valorTipoA = valorTipoA - (valorTipoA *0.03);
            valorTotal = valorTipoA *litros;
        }else{
            valorTipoA = valorTipoA - (valorTipoA * 0.05);
            valorTotal = valorTipoA *litros;
        }
    }else{
        console.log("Tipo invalido!")
    }
    
    console.log("Total a ser pago: R$"+ valorTotal);
}

module.exports = Exercicio4;