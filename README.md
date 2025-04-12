# Raycast
### Dupla: Maria Eduarda da Silva Souza e Sabrina Caetano
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

## Atribuições da dupla

Maria Eduarda:
<br>
Sabrina Caetano:
