function Exercicio5(){
    const readline = require('readline');

    const rl = readline.createInterface({
        input: process.stdin,
        output: process.stdout
    });
    
    function calcularPreco(tipoCarne, quantidade, cartaoAssai) {
        const precos = {
            "File Duplo": [4.90, 5.80],
            "Alcatra": [5.90, 6.80],
            "Picanha": [6.90, 7.80]
        };
    
        const precoPorKg = quantidade > 5 ? precos[tipoCarne][1] : precos[tipoCarne][0];
        const precoTotal = precoPorKg * quantidade;
        const desconto = cartaoAssai ? 0.05 * precoTotal : 0;
        const precoFinal = precoTotal - desconto;
    
        return [precoPorKg, precoTotal, desconto, precoFinal];
    }
    
    console.log("Bem-vindo(a) ao Hipermercado Assaí!");
    
    const carrinho = [];
    
    function comprarCarne() {
        rl.question("Digite o tipo de carne (File Duplo, Alcatra ou Picanha, ou 'FIM' para finalizar): ", tipoCarne => {
            if (tipoCarne.toUpperCase() === "FIM") {
                exibirCupom();
                rl.close();
            } else {
                rl.question(`Digite a quantidade de carne ${tipoCarne} em Kg: `, quantidade => {
                    rl.question(`Você possui o cartão Assaí para a carne ${tipoCarne}? (S para Sim, N para Não): `, cartaoAssaiInput => {
                        const cartaoAssai = cartaoAssaiInput.toUpperCase() === "S";
    
                        const [precoPorKg, precoTotal, desconto, precoFinal] = calcularPreco(tipoCarne, parseFloat(quantidade), cartaoAssai);
    
                        carrinho.push({
                            tipo: tipoCarne,
                            quantidade: parseFloat(quantidade),
                            precoPorKg: precoPorKg,
                            precoTotal: precoTotal,
                            cartaoAssai: cartaoAssai,
                            desconto: desconto,
                            precoFinal: precoFinal
                        });
    
                        comprarCarne();
                    });
                });
            }
        });
    }
    
    function exibirCupom() {
        console.log("\nCupom Fiscal:");
        let valorTotal = 0;
        for (const item of carrinho) {
            console.log(`Tipo de carne: ${item.tipo}`);
            console.log(`Quantidade: ${item.quantidade.toFixed(2)} Kg`);
            console.log(`Preço por Kg: R$ ${item.precoPorKg.toFixed(2)}`);
            console.log(`Preço total: R$ ${item.precoTotal.toFixed(2)}`);
            console.log(`Tipo de pagamento: ${item.cartaoAssai ? 'Cartão Assaí' : 'Outro método'}`);
            console.log(`Desconto: R$ ${item.desconto.toFixed(2)}`);
            console.log(`Valor a pagar: R$ ${item.precoFinal.toFixed(2)}\n`);
            valorTotal += item.precoFinal;
        }
        console.log(`Valor total a pagar: R$ ${valorTotal.toFixed(2)}`);
    }
    
    comprarCarne();
}

module.exports = Exercicio5;