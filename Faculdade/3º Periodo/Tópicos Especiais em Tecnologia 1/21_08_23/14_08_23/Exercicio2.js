function Exercicio2(valorHora, hora){
    let salario = valorHora * hora;
    let aux1 = 0;
    let aux2 = 0;
    let aux3 = 0;
    
    function Ir(salario){
        let valor = 0;
        let percentual = "";
        
        if(salario <= 900){
            valor = 0;
            percentual = "Insento"
        }else if(salario <= 1500){
            valor = salario * 0.05;
            percentual = "5%"
        }else if (salario <= 2500){
            valor = salario * 0.1;
            percentual = "10%"
        }else{
            valor = salario * 0.2;
            percentual = "20%"
        }
    
        aux1 = valor;
    
        return "(-) IR ("+ percentual +") :R$"+ valor;
    }
    
    function Inss(salario){
        let valor = 0;
        valor = salario * 0.1;
    
        aux2 = valor;
    
        return "(-) INSS (10%) :R$" + valor;
    }
    
    function Fgts(salario){
        let valor = 0;
        valor = (salario*0.11);
        return "FGTS (11%) :R$" + valor;
    }
    
    function deducoes(salario){
        let valor = 0;
        valor = aux2 + aux1;
        aux3 = valor;
        return "Total de descontos :R$" + valor;
    }
    
    function SalarioLiquido(salario){
        let valor = 0;
        valor = salario - aux3;
        return "Salário Liquido :R$" + valor;
    }
    
    console.log("Salário Bruto: ("+hora+"h * R$"+valorHora+")");
    console.log(Ir(salario));
    console.log(Inss(salario));
    console.log(Fgts(salario));
    console.log(deducoes(salario));
    console.log(SalarioLiquido(salario));
}

module.exports = Exercicio2;