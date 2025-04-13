# Raycast
### Dupla: Maria Eduarda da Silva Souza e Sabrina Caetano, 3º Jogos Digitais
Repositório destinado aos estudos de Raycast do Unity.<br>

## Descrição do código

>**RaycastHit rayhit**;

**RaycastHit:** É uma variável do tipo RaycastHit sendo bastante utilizada para retornar a informação de um raio, ou seja, nesse caso todas as informações possíveis de acordo com sua posição esse raio irá passar.
<br>**Rayhit:** Colisão, o resultado do raycast.

>**Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));**

**Ray ray:** Cria um raio que vem da câmera do jogador (Camera.main) na qual a mesma é a tela do jogador.<br>
**ScreenPointToRay:**  Cria o raio a partir de um ponto da câmera/tela.<br>
**Screen.width / 2 e Screen.height / 2** pegam as coordenadas do meio da tela, ou seja, de onde o raio irá sair.<br>
**ScreenPointToRay:** Transforma esse ponto da tela em um raio real na cena.<br>

>**if (Physics.Raycast(ray, out rayhit, 1f))**

**Physics.Raycast:** Lança o raio e verifica se colidiu. <br>
**ray** é o raio que criamos. <br>
**out rayhit** armazena as informações da colisão, caso aconteça. <br>
**1f** é a distância máxima do raio — ou seja, ele só "alcança" 1 unidade de distância à frente da câmera.

>**if (rayhit.collider.tag == "object")**<br>
>**Debug.Log("Olhou");**<br>
>**Destroy(rayhit.collider.gameObject);**

Se o objeto atingido/colidido tiver a tag "object", então ele irá mostrar a mensagem "Olhou" e também de acordo com seu raio máximo ele irá destruir esse objeto com a tag após a colisão (rayhit.collider.gameObject).

### Conceito

**Prefab:** É um modelo na qual pegamos um objeto 3D, com scripts e alterações visuais e salvamos como um _Prefab_, ou seja, um prefab é um modelo com todos os scripts e alterações visuais feitas que viraram um molde que você pode simplesmente arrastar e terá ele feito. O molde do jogador (o cilindro) se tornou um prefab para salvar as configurações de tamanho, posição de câmera e scripts.<br>
<br>
**Raycast:** É a criação de um raio invisível, a partir de um ponto no espaço, numa direção específica, e ver se ele atinge algo. Ele pode se tornar visível com algumas alterações no código, configurando a sua cor e o intervalo para ele aparecer.<br>
<br>
**Destroy:** É uma função na qual o objeto, a partir do contato/colisão do raycast, que o gameobject identificado/colidido será destruído porém pode ser qualquer coisa.

## Mídia

![IMGInicio](https://github.com/SouzaDuda/Raycast/blob/main/IMG1.png)
![IMGInicioEmFrenteAoCubo](https://github.com/SouzaDuda/Raycast/blob/main/IMG2.png)
![IMGOlhou](https://github.com/SouzaDuda/Raycast/blob/main/IMG3.png)

Link do vídeo:<br>
https://drive.google.com/drive/folders/1CmyD6Rd4we8DMlDr5yabypHkY-gleSlY?usp=drive_link<br>
> OBS: O console.log não aparece no vídeo mas segue uma imagem das mensagens

![IMGConsole](https://github.com/SouzaDuda/Raycast/blob/main/IMG4.png)

## Atribuições da dupla
Todo o projeto foi feito junto, ambos os integrantes auxiliaram no código e na correção do raycast, ou seja, participamos em todo o desenvolvimento.
