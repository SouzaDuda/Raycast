# Raycast
### Dupla: Maria Eduarda da Silva Souza e Sabrina Caetano
Repositório destinado aos estudos de Raycast do Unity.<br>

## Descrição do código

>**RaycastHit rayhit**;

RaycastHit: É uma variável do tipo RaycastHit sendo bastante utilizada para retornar a informação de um raio, ou seja, nesse caso todas as informações possíveis de acordo com sua posição esse raio irá passar.
Rayhit: Colisão, o resultado do raycast.

>**Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));**

Ray ray: Cria um raio que vem da câmera do jogador (Camera.main) na qual a mesma é a tela do jogador.
ScreenPointToRay:  Cria o raio a partir de um ponto da câmera/tela.
Screen.width / 2 e Screen.height / 2 pegam as coordenadas do meio da tela, ou seja, de onde o raio irá sair.
ScreenPointToRay: Transforma esse ponto da tela em um raio real na cena.

>**if (Physics.Raycast(ray, out rayhit, 1f))**

Physics.Raycast: Lança o raio e verifica se colidiu.
ray é o raio que criamos.
out rayhit armazena as informações da colisão, caso aconteça.
1f é a distância máxima do raio — ou seja, ele só "alcança" 1 unidade de distância à frente da câmera.

>**if (rayhit.collider.tag == "object")**
>**Debug.Log("Olhou");**
>**Destroy(rayhit.collider.gameObject);**

Se o objeto atingido/colidido tiver a tag "object", então ele irá mostrar a mensagem "Olhou" e também de acordo com seu raio máximo ele irá destruir esse objeto com a tag.
