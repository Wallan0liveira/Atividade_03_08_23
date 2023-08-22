function Exercicio1(salario){
    let novoSalario = 0;
    let Percentual;
    let reajuste = 0;
    
    if (salario <= 280) {
        novoSalario = salario + (salario*0.2)
        Percentual = "20%"
    }else if(salario <= 700){
        novoSalario = salario + (salario*0.15)
        Percentual = "15%"
    }else if(salario <= 1500){
        novoSalario = salario + (salario*0.1)
        Percentual = "10%"
    }else{
        novoSalario = salario + (salario*0.05)
        Percentual = "5%"
    }
    
    reajuste = novoSalario - salario;
    
    console.log("Salário antes do reajuste R$"+ salario);
    console.log("Percentual de reajuste: "+ Percentual);
    console.log("Valor do reajuste R$" + reajuste)
    console.log("Salário reajustado R$"+ novoSalario);
}

module.exports = Exercicio1;