using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App5.Pages
{
	public class ServicosPage : ContentPage
	{
		public ServicosPage()
		{
			Title = "Problemas e Soluções";

			var lista = new ListView();

			lista.ItemsSource = new[] {
				"Internet lenta",
				"Computador lento e/ou travando",
				"Hora e data desatualizada",
				"Computador desligando ou reiniciando sozinho",
				"Mouse travando",
				"Inicialização lenta",
				"Erro no HD"
			};

			lista.ItemTapped += (sender, e) =>
			{
				var item = (string)((ListView)sender).SelectedItem;

				switch (item) {
					case "Internet lenta":
						DisplayAlert("Internet lenta", "Seu provedor de internet está enviando o pacote correspondente " +
							"ao plano assinado, porém seu computador não está recebendo de maneira correta." + "\r\n" + "\r\n" +
							"Possível solução: Desinstale alguns programas que comprometem a banda da sua internet, complementos, plug - ins e extensões desnecessárias como PSafe, Yac, websearches, entre outros.Eles sobrecarregam e consomem sua internet.Você também pode usar o RevoUninstaller.", "OK");
						((ListView)sender).SelectedItem = null;
						break;

					case "Computador lento e/ou travando":
						DisplayAlert("Computador lento e/ou travando",
							"Demorando a abrir ou carregar programas; travando quando executa um arquivo mais pesado." + "\r\n" + "\r\n" +
							"Possível solução: pode ser ocasionado por problemas de memórias sujas ou em conflitos." +
							" No caso de sujeira, com o computador desligado, abra o gabinete e remova o pente de memória do slot e passe uma" +
							" borracha em seus contatos e encaixe-os novamente. Se você tem mais de uma memória verifique se são as mesmas especificações." +
							" Tanto no barramento quanto na frequência, essas informações costumam estar nos adesivos ou embalagens da memória. Quando há diferença costuma ocorrer conflitos entre elas. " +
							"Certifique - se de estar totalmente certo dos precedimentos que irá realizar, afinal, eventuais erros de manuseamento dos equipamentos " +
							"podem danificar seu PC.Lembre - se também de descarregar a energia estática, repousando suas mãos em objetos metálicos, antes de tocar no hardware do seu computador.", 
							"OK");
						((ListView)sender).SelectedItem = null;
						break;

					case "Hora e data desatualizada":
						DisplayAlert("Hora e data desatualizada",
							"Sempre que você liga o PC, o sistema pede pra apertar F1 e solicita atualização de hora e data." + "\r\n" + "\r\n" +
							"Possível solução: bateria descarregada. Nesse caso troque-a por uma nova, ela se encarrega de memorizar estas informações para o computador." +
							" Com o PC desligado, abra o gabinete e localize a bateria, parecida com uma pilha de um relógio de pulso, desprenda do encaixe e troque.",
							"OK");
						((ListView)sender).SelectedItem = null;
						break;

					case "Computador desligando ou reiniciando sozinho":
						DisplayAlert("Computador desligando ou reiniciando sozinho",
							"Costuma ocorrer por vários motivos, quando sua temperatura está elevada, como medida de segurança ele desliga ou reinicia sozinho." + "\r\n" + "\r\n" +
							"Possível solução: abra o computador e verifique se há muita sujeira, limpe se necessário. Se possível acrescente mais coolers e troque a pasta térmica do" +
							" processador, removendo o dissipador de calor. Se sobre o processador já estiver alguma pasta térmica, utilize um pano macio e enxuto para remover. Sem remover o processador," +
							" passe uma nova pasta e encaixe novamente o dissipador.",
							"OK");
						((ListView)sender).SelectedItem = null;
						break;

					case "Mouse travando":
						DisplayAlert("Mouse travando",
							"Outro problema frequente é o travamento do cursor, ele para por alguns segundos e volta a funcionar normalmente." + "\r\n" + "\r\n" +
							"Possível solução: teste outro mouse, se o problema persistir escaneie seu computador, há tipos de vírus que infectam " +
							"o seu mouse, deixando-o inoperante. Outra solução é verificar se seu driver está instalado corretamente.",
							"OK");
						((ListView)sender).SelectedItem = null;
						break;

					case "Inicialização lenta":
						DisplayAlert("Inicialização lenta",
							"Seu PC demora muito para iniciar por completo. Há vários programas sendo executados junto com a inicialização do Windows." + "\r\n" + "\r\n" +
							"Possível solução: utilize o comando msconfig, depois de precionar a tecla do windows + R, para desabilitar alguns programas de" +
							" inicialização. Limpe o registro do Windows com o programa Ccleaner. Com isso, possivelmente resolverá seu problema.",
							"OK");
						((ListView)sender).SelectedItem = null;
						break;

					case "Erro no HD":
						DisplayAlert("Erro no HD",
							"Seu computador não reconhece seu HD ou apresenta mensagens de erros." + "\r\n" + "\r\n" +
							"Possível solução: teste outro HD, se o problema persistir, verifique se os cabos estão" +
							" em boas condições e bem encaixados. Utilize também o CHKDSK para reparar setores defeituosos no HD. Caso o" +
							" problema persista, leve seu PC ao técnico mais próximo.",
							"OK");
						((ListView)sender).SelectedItem = null;
						break;

				}

			};

			Content = lista;
		}
	}
}