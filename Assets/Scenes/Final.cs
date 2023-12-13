using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    private void Start()
    {
        //Ejercicio 1
        Power();

        //Ejercicio 2
        //ApplyPotion(2);
        PotionToConsume();

        //Ejercicio 3
        //EjecutionSwordStats(155, 65, 69);
        EquipSword();

        //Ejercicio 4
        //ChainHits(300);
        ApplyChainHits();

        //Ejercicio 5
        Turret();

        //Ejercicio 6
        LevelWanted(3);

        //Ejercicio 7
        //Winner(6);
        Turns();

        //Ejercicio 8 
        PlayersList();

        //Ejercicio 9
        Tetris(50, 10);

        //Ejercicio 10
        MinecraftMod(100, 80);
    }

    #region Ejercicio 1
    /*1) En un juego de Rol de Naves hay que calcular la potencia con la que el disparo de 
    nuestra nave golpea al enemigo.
    Dicha potencia se calcula tomando un 150% del daño base, más un 25% de la 
    vida del enemigo.
    Sabiendo que:
        • El enemigo tiene un daño base que varía entre 100 y 300.
        • La vida del enemigo varía entre 300 y 600.
    Construir un método que no reciba nada por parámetro, simule lo indicado y
    devuelva el daño recibido por el enemigo.
    */

    private void Power()
    {
        int _enemyBaseDamage = Random.Range(100, 300 + 1);
        int _enemyLife = Random.Range(300, 600 + 1);

        float _power = _enemyBaseDamage * 1.5f + _enemyLife * 0.25f;

        Debug.Log("EJ1. El daño recibido por el enemigo es: " + _power);
    }

    #endregion
    #region Ejercicio 2
    /*2) En un juego de rol un personaje puede alterar el valor de sus stats dependiendo 
        de qué tipo de poción consuma:
        Cada poción se identifica con un número que va del 0 al 3:
            • Si se consume una poción de Agilidad (0), la destreza y la evasión aumentan
            un 25%.
            • Si se consume una poción de Fuerza (1) aumentará el poder de ataque un 33%.
            • Si se consume una poción de Vida (2), el personaje aumentará un 25% su vida 
            máxima.
            • Si se consume una poción de Inteligencia (3) aumentará su poder mágico un
            20% y un 35% el mana máximo.

        Sabiendo que los stats base del personaje son:
            • Destreza → entre 20 y 30
            • Evasión → entre 33 y 50
            • Poder de ataque → entre 300 y 600
            • Poder mágico → entre 500 y 900
            • Vida máxima → entre 4000 y 5000
            • Maná máximo → entre 500 y 1000

        Construya un método que reciba el número de poción a consumir, simule lo 
        mencionado y sin devolver nada indique:
            a) El valor de las stats antes y después de ser modificadas.
            b) Que poción se tomó.*/

    private void ApplyPotion(int potion)
    {
        int _skill = Random.Range(20, 31);
        int _evasion = Random.Range(33, 51);
        int _attackPower = Random.Range(300, 601);
        int _magicPower = Random.Range(500, 901);
        int _maxLife = Random.Range(4000, 5001);
        int _maxMana = Random.Range(500, 1001);

        switch (potion)
        {
            case 0:
                float skill = _skill * 1.25f;
                float evasion = _evasion * 1.25f;
                Debug.Log("EJ2. Tomó la poción de Agilidad");
                Debug.Log("EJ2. El valor original de Destreza es " + _skill + ". Con la poción de Agilidad es: " + skill);
                Debug.Log("EJ2. El valor original de Evasión es " + _evasion + ". Con la poción de Agilidad es: " + evasion);
                break;
            case 1:
                float attackPower = _attackPower * 1.33f;
                Debug.Log("EJ2. Tomó la poción de Fuerza");
                Debug.Log("EJ2. El valor original del Poder de Ataque es " + _attackPower + ". Con la poción de Fuerza es: " + attackPower);
                break;
            case 2:
                float maxLife = _maxLife * 1.25f;
                Debug.Log("EJ2. Tomó la poción de Vida");
                Debug.Log("EJ2. El valor original de la Vida Máxima es " + _maxLife + ". Con la poción de Vida es: " + maxLife);
                break;
            case 3:
                float magicPower = _magicPower * 1.2f;
                float maxMana = _maxMana * 1.35f;
                Debug.Log("EJ2. Tomó la poción de Inteligencia");
                Debug.Log("EJ2. El valor original del Poder Mágico es " + _magicPower + ". Con la poción de Inteligencia es: " + magicPower);
                Debug.Log("EJ2. El valor original del Maná máximo es " + _maxMana + ". Con la poción de Inteligencia es: " + maxMana);
                break;
        }
    }

    private void PotionToConsume()
    {
        int potion = Random.Range(0, 4);
        ApplyPotion(potion);
    }

    #endregion
    #region Ejercicio 3
    /*3) En el diablo 2 la espada de ejecución tiene como requisitos para ser equipada los 
        siguientes valores de stats:
            Fuerza → 155
            Destreza → 65
            Nivel → 69

        Los stats iniciales del jugador varían de la siguiente forma:
            • Fuerza → entre 50 y 200
            • Destreza → entre 20 y 100
            • Nivel → entre 1 y 99

        Construir un método que reciba el valor de Fuerza, Destreza y Nivel actual, simule
        lo mencionado y devuelva un texto que indicando si pudo o no equipar la espada. 
        En el caso de que no pueda equiparla, el mismo texto debe indicar qué y cuánto 
        faltó para poder equiparla.*/


    private void EjecutionSwordStats(int force, int skill, int lvl)
    {
        int _forceRequired = 155;
        int _skillRequired = 65;
        int _levelRequired = 69;

        if (force >= _forceRequired && skill >= _skillRequired && lvl >= _levelRequired)
        {
            Debug.Log("EJ3. Pudo equipar la Espada de Ejecución!");
        }
        else
        {
            if (force < _forceRequired)
            {
                int _missingForce = _forceRequired - force;
                Debug.Log("EJ3. No pudo equipar la espada. Tiene " + force + " puntos de Fuerza, le faltan " + _missingForce + " puntos");
            }
            if (skill < _skillRequired)
            {
                int _missingSkill = _skillRequired - skill;
                Debug.Log("EJ3. No pudo equipar la espada. Tiene " + skill + " puntos de Destreza, le faltan " + _missingSkill + " puntos");

            }
            if (lvl < _levelRequired)
            {
                int _missingLevel = _levelRequired - lvl;
                Debug.Log("EJ3. No pudo equipar la espada. Tiene nivel " + lvl + ", le falta " + _missingLevel + " niveles");
            }
        }
    }

    private void EquipSword()
    {
        int _force = Random.Range(50, 201);
        int _skill = Random.Range(20, 101);
        int _level = Random.Range(1, 100);

        EjecutionSwordStats(_force, _skill, _level);
    }

    #endregion
    #region Ejercicio 4
    /*4) En un juego de pelea se utiliza la habilidad cadena de golpes, donde el rival 
    recibirá golpes consecutivos hasta que alguno de los golpes dados valga 0 o el 
    daño total realizado sea mayor a 400.

    Sabiendo que los golpes individuales hacen un daño que varía entre 0 y 30 y que 
    la vida del enemigo varía entre 300 y 500, construya un método que reciba por 
    parámetro la vida del enemigo, simule lo mencionado y devuelva si el enemigo 
    falleció o no con un dato de tipo bool.

    Además, dentro del método debe indicar:
        a) Cuántos golpes se realizaron.
        b) Cuál fue el daño final.*/

    private void ChainHits(int enemyLife)
    {
        int _totalDamage = 0;
        int _hits = 0;

        while (_totalDamage <= 400 && enemyLife > 0)
        {
            int _damage = Random.Range(0, 31);
            enemyLife -= _damage;
            _totalDamage += _damage;
            _hits++;

            if (_damage == 0)
            {
                Debug.Log("EJ4. Daño 0");
                break;
            }
        }

        Debug.Log("EJ4. Se recibieron " + _hits + " golpes. El daño total fue " + _totalDamage);

        if (enemyLife <= 0)
        {
            Debug.Log("EJ4. El enemigo murió");
        }
    }

    private void ApplyChainHits()
    {
        int _enemyLife = Random.Range(300, 501);
        Debug.Log("EJ4. La vida del enemigo es " + _enemyLife);
        ChainHits(_enemyLife);
    }
    #endregion
    #region Ejercicio 5
    /*5) En un juego de supervivencia, la muralla tiene una torreta que tiene 3 estados:
            • Pasivo: no realiza ningún ataque.
            • Defensivo: genera un disparo simple por turno a cada enemigo.
            • UltraDefensivo: genera un disparo especial por turno a cada enemigo.

        Se sabe que:
            - Si la cantidad de enemigos es cero, el estado de la torreta será pasivo.
            - Si la cantidad de enemigos está entre 1 y 10, el estado de la torreta será
            Defensivo.
            - Si la cantidad de enemigos es mayor a 10, el estado de la torreta será
            UltraDefensivo.

        Además, se sabe que la cantidad de enemigos por turno varía entre 0 y 20, el 
        daño simple entre 10 y 20, y el daño especial entre 40 y 80.
        Se debe construir un método que reciba por parámetro la cantidad de enemigos
        del turno, simule lo indicado y devuelva el daño total, habiendo indicado 
        previamente el estado de la torreta.

        Simule esto durante 15 turnos e indique el daño total acumulado a los
        enemigos en contacto con la torreta.*/

    private void Turret()
    {
        int _turns = 15;
        int _totalDamage = 0;

        for (int i = 1; i <= _turns; i++)
        {
            int _enemies = Random.Range(0, 21);

            int _damage = TurretAttack(_enemies);

            _totalDamage += _damage;

            //Debug.Log("Turno: " + i + " - Enemigos: " + _enemies);
        }

        Debug.Log("EJ5. Daño total: " + _totalDamage);
    }

    private int TurretAttack(int enemies)
    {
        int _damage = 0;

        if (enemies == 0)
        {
            Debug.Log("EJ5. Estado de la torreta: Pasivo");
        }
        else if (enemies >= 1 && enemies <= 10)
        {
            Debug.Log("EJ5. Estado de la torreta: Defensivo");
            _damage = Random.Range(40, 81) * enemies;
        }
        else
        {
            Debug.Log("EJ5. Estado de la torreta: Ultra Defensivo");
            _damage = Random.Range(10, 21) * enemies;
        }

        return _damage;
    }
    #endregion
    #region Ejercicio 6
    /*6) En un juego RPG, un personaje irá subiendo de nivel a medida que gane una 
        cierta cantidad de experiencia.
        
        El algoritmo detrás de esto define que para llegar a un X nivel se necesita la 
        experiencia del anterior más un 50%. La experiencia mínima es de 8 puntos.
        Por ejemplo: Para pasar del nivel 1 al nivel 2 se necesitarán 12 puntos de 
        experiencia. Para pasar del nivel 2 al nivel 3 se necesitará la misma cantidad que 
        en el nivel anterior con un 50% añadido, resultando en 18.
    
        Construya un método que reciba por parámetro el nivel que se desea tener, 
        simule lo mencionado y devuelva el valor total de experiencia necesaria para 
        alcanzar dicho nivel.*/

    private void LevelWanted(int lvl)
    {
        float minExperience = 8f;

        float previousLvlExp = minExperience;

        for (int i = 2; i <= lvl; i++)
        {
            previousLvlExp += previousLvlExp * 0.5f;
        }

        Debug.Log("EJ6. La experiencia que requiere para llegar al nivel deseado es de: " + previousLvlExp + " puntos de experiencia");

        if (lvl < 1)
        {
            Debug.Log("EJ6. Experiencia requerida: " + minExperience);
        }
    }


    #endregion
    #region Ejercicio 7
    /*7) En un desafío del Super Smash Bros, cuatro personajes se enfrentan a lo largo de 
        varias rondas (Mario, Kong, Pikachu, Link), en cada una se debe recolectar
        esferas. Cada personaje puede recolectar entre 10 y 30 esferas por turno.
        Cada personaje deberá tener su array en donde se irán guardado los puntos que 
        consiguió en cada turno.

        Construya un método que reciba por parámetro la cantidad de turnos que debe
        Simular (siendo entre 5 y 10 turnos), simule lo indicado y devuelva el nombre del 
        personaje que ganó la competencia (gana quien tenga más rondas ganadas).

        A su vez, al finalizar los turnos debe indicar:
            a) Cuantas esferas en total recolectaron todos los personajes en cada turno:
            Por ejemplo: Turno 1 se recolectaron 59 esferas, Turno 2 se recolectaron 
            65 esferas, etc.
            b) Indicar quién fue el ganador de cada ronda (en caso de que haya un 
            empate nadie gana la ronda).*/

    private void Turns()
    {
        int _turns = Random.Range(5, 11);
        Debug.Log("EJ7. Cantidad de turnos: " + _turns);
        Winner(_turns);
    }

    private void Winner(int turns)
    {
        List<int> marioSpheres = new List<int>();
        int marioWins = 0;

        List<int> kongSpheres = new List<int>();
        int kongWins = 0;

        List<int> pikachuSpheres = new List<int>();
        int pikachuWins = 0;

        List<int> linkSpheres = new List<int>();
        int linkWins = 0;

        List<int> totalSpheres = new List<int>();

        for (int i = 0; i < turns; i++)
        {
            int marioTurn = Random.Range(10, 31);
            marioSpheres.Add(marioTurn);

            int kongTurn = Random.Range(10, 31);
            kongSpheres.Add(kongTurn);

            int pikachuTurn = Random.Range(10, 31);
            pikachuSpheres.Add(pikachuTurn);

            int linkTurn = Random.Range(10, 31);
            linkSpheres.Add(linkTurn);

            totalSpheres.Add(marioTurn + kongTurn + pikachuTurn + linkTurn);

            Debug.Log("EJ7. Turno: " + (i + 1) + " - Se recolectaron " + totalSpheres[i] + " esferas en total.");

            int winner = Mathf.Max(Mathf.Max(marioSpheres[i], kongSpheres[i]), Mathf.Max(pikachuSpheres[i], linkSpheres[i]));

            if (marioSpheres[i] == winner)
            {
                marioWins++;
            }
            if (kongSpheres[i] == winner)
            {
                kongWins++;
            }
            if (pikachuSpheres[i] == winner)
            {
                pikachuWins++;
            }
            if (linkSpheres[i] == winner)
            {
                linkWins++;
            }


        }

        if (marioWins > kongWins && marioWins > pikachuWins && marioWins > linkWins)
        {
            Debug.Log("EJ7. El ganador de la competencia es Mario");
        }
        else if (kongWins > marioWins && kongWins > linkWins && kongWins > pikachuWins)
        {
            Debug.Log("EJ7. El ganador de la competencia es Kong");
        }
        else if (pikachuWins > marioWins && pikachuWins > kongWins && pikachuWins > linkWins)
        {
            Debug.Log("EJ7. El ganador de la competencia es Pikachu");
        }
        else if (linkWins > marioWins && linkWins > kongWins && linkWins > pikachuWins)
        {
            Debug.Log("EJ7. El ganador de la competencia es Link");
        }
        else if (marioWins == kongWins || marioWins == pikachuWins || marioWins == linkWins ||
                 kongWins == marioWins || kongWins == linkWins || kongWins == pikachuWins ||
                 pikachuWins == marioWins || pikachuWins == kongWins || pikachuWins == linkWins ||
                 linkWins == marioWins || linkWins == kongWins || linkWins == pikachuWins)
        {
            Debug.Log("EJ7. Hubo empate.");
        }
    }
    #endregion
    #region Ejercicio 8
    /*8) En un juego de Fórmula 1 que cuenta con un sistema de posiciones mundiales,
    recibimos una Lista/Array con los puntajes de 400 jugadores. Dichos puntajes
    varían entre 10 y 4000 puntos.

    Sabemos que:
        • Aquellos que tengan más de 3750 puntos juegan en la liga Diamante.
        • Aquellos que tengan entre 3000 y 3750 puntos juegan en la liga Platino.
        • Aquellos que tengan entre 2000 y 2999 puntos juegan en la liga Oro.
        • Aquellos que tengan entre 1000 y 1999 puntos juegan en la liga Plata.
        • Aquellos que tengan entre 500 y 999 puntos juegan en la liga Bronce.
        • Aquellos que tengan entre 0 y 499 puntos no están aptos para jugar en
        ninguna liga.

    Construya un método que reciba por parámetro la Lista/Array de puntajes y sin
    devolver nada, indique cuántos hay en cada liga y cuantos no formar parte de
    ninguna liga.
    */

    private void PositionsSystem(List<int> positions)
    {
        int diamondLeague = 0;
        int platinumLeague = 0;
        int goldLeague = 0;
        int silverLeague = 0;
        int bronzeLeague = 0;
        int unfitParticipants = 0;

        foreach (int score in positions)
        {
            if (score > 3750) diamondLeague++;
            else if (score >= 3000 && score < 3750) platinumLeague++;
            else if (score >= 2000 && score <= 2999) goldLeague++;
            else if (score >= 1000 && score <= 1999) silverLeague++;
            else if (score >= 500 && score <= 999) bronzeLeague++;
            else unfitParticipants++;
        }

        Debug.Log("EJ8. Total de participantes de la Liga Diamante: " + diamondLeague);
        Debug.Log("EJ8. Total de participantes de la Liga Platino: " + platinumLeague);
        Debug.Log("EJ8. Total de participantes de la Liga Oro: " + goldLeague);
        Debug.Log("EJ8. Total de participantes de la Liga Plata: " + silverLeague);
        Debug.Log("EJ8. Total de participantes de la Liga Bronce: " + bronzeLeague);
        Debug.Log("EJ8. Total de participantes no aptos: " + unfitParticipants);
    }

    private void PlayersList()
    {
        List<int> playersList = new List<int>();

        for (int i = 0; i < 400; i++)
        {
            int participantsScores = Random.Range(10, 4000 + 1);
            playersList.Add(participantsScores);
        }

        PositionsSystem(playersList);
    }
    #endregion
    #region Ejercicio 9
    /*9) En un juego de tetris tenemos una matriz de 50 filas y 10 columnas, dentro de la
    cual habrá valores aleatorios entre 0 y 1, donde 0 significa un casillero vacío, y 1
    un casillero lleno.

    Construya un método que reciba el número de filas y columnas de la matriz
    necesaria y la devuelva generada teniendo en cuenta que dentro del método se
    debe simular lo siguiente:
        a) La matriz se debe llenar con valores aleatorios (0 o 1) sabiendo que la
        chance de que sea 1 es igual al 2% por el número de fila.
        b) Debe identificar e indicar si alguna fila posee todos los casilleros llenos o
        todos vacíos.*/

    private void Tetris(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int randomNumber = Random.Range(0, 101);

                int probabilityNumOne = 2 * (row + 1);

                matrix[row, col] = randomNumber < probabilityNumOne ? 1 : 0;
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool ones = true;
            bool zeros = true;

            for (int q = 0; q < matrix.GetLength(1); q++)
            {
                if (matrix[i, q] != 1)
                {
                    ones = false;
                }

                if (matrix[i, q] != 0)
                {
                    zeros = false;
                }
            }

            if (ones)
            {
                Debug.Log("EJ9. La fila " + (i + 1) + " está formada por unos.");
            }

            if (zeros)
            {
                Debug.Log("EJ9. La fila " + (i + 1) + " está formada por ceros.");
            }
        }
    }
    #endregion
    #region Ejercicio 10
    /*10) Se debe programar un mod para Minecraft que genere a partir de una matriz de
    dos dimensiones una estructura antigua en ruinas.

    Para esto se debe tener en cuenta que:
        • La matriz es de tipo string y tiene 100 filas y 80 columnas.
        • En la matriz aparecen cinco tipos de estructuras diferentes, cada una con
        chances distintas de aparecer:
            ○ “Bloque de Tierra” → 40%
            ○ “Bloque de Piedra” → 25%
            ○ “Bloque de Carbón” → 10%
            ○ “Bloque de Hierro” → 15%
            ○ “Bloque de Obsidiana” → 10%
        • Existe un 3% de chance de que al momento de generarse un “Bloque de
        Carbón” este sea reemplazada por un “Bloque de Diamante”.
        • Hay un 1% de chances de que, en vez de generar un Bloque, se genere un
        Cofre Antiguo.

    Construya un método que reciba el número de filas y de columnas, simule todo
    lo mencionado anteriormente y devuelva la matriz generada.

    Además, el método debe indicar:
        a) Cuantos elementos de cada tipo se encuentran en la matriz.
        Ej: 35 Bloque de Carbón, 62 Bloque de Hierro, etc.
        b) En caso de encontrarse uno o más cofres antiguos, mostrar las
        coordenadas donde se encuentran.*/

    private void MinecraftMod(int rows, int cols)
    {
        string[,] ruins = new string[rows, cols];

        int ancientChestChance = 1;
        int dirtBlockChance = 40;
        int stoneBlockChance = 25;
        int coalBlockChance = 10;
        int ironBlockChance = 15;
        int obsidianBlockChance = 10;
        int coalAsDiamondChance = 3;

        int ancientChestX = -1;
        int ancientChestY = -1;

        int dirtBlocks = 0;
        int stoneBlocks = 0;
        int coalBlocks = 0;
        int ironBlocks = 0;
        int obsidianBlocks = 0;
        int diamondBlocks = 0;
        int ancientChestBlocks = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int blockType = Random.Range(1, 101);

                if (blockType <= dirtBlockChance)
                {
                    ruins[row, col] = "Bloque de Tierra";
                    dirtBlocks++;
                }
                else if (blockType <= dirtBlockChance + stoneBlockChance)
                {
                    ruins[row, col] = "Bloque de Piedra";
                    stoneBlocks++;
                }
                else if (blockType <= dirtBlockChance + stoneBlockChance + coalBlockChance)
                {
                    int coalOrDiamond = Random.Range(1, 101); 

                    if (coalOrDiamond <= coalAsDiamondChance)
                    {
                        ruins[row, col] = "Bloque de Diamante";
                        diamondBlocks++;
                    }
                    else
                    {
                        ruins[row, col] = "Bloque de Carbón";
                        coalBlocks++;
                    }
                }
                else if (blockType <= dirtBlockChance + stoneBlockChance + coalBlockChance + ironBlockChance)
                {
                    ruins[row, col] = "Bloque de Hierro";
                    ironBlocks++;
                }
                else if (blockType <= dirtBlockChance + stoneBlockChance + coalBlockChance + ironBlockChance + obsidianBlockChance)
                {
                    ruins[row, col] = "Bloque de Obsidiana";
                    obsidianBlocks++;
                }
                else
                {
                    if (Random.Range(1, 101) <= ancientChestChance)
                    {
                        ruins[row, col] = "Cofre Antiguo";
                        ancientChestBlocks++;
                        ancientChestX = row;
                        ancientChestY = col;
                    }
                    else
                    {
                        ruins[row, col] = "Bloque de Tierra";
                        dirtBlocks++;
                    }
                }
            }
        }

        Debug.Log("EJ10. Bloque de Tierra: " + dirtBlocks);
        Debug.Log("EJ10. Bloque de Piedra: " + stoneBlocks);
        Debug.Log("EJ10. Bloque de Carbón: " + coalBlocks);
        Debug.Log("EJ10. Bloque de Hierro: " + ironBlocks);
        Debug.Log("EJ10. Bloque de Obsidiana: " + obsidianBlocks);
        Debug.Log("EJ10. Bloque de Diamante: " + diamondBlocks);
        Debug.Log("EJ10. Cofres Antiguos: " + ancientChestBlocks);

        if (ancientChestBlocks > 0)
        {
            Debug.Log("EJ10. Coordenadas del Cofre Antiguo: " + (ancientChestX, ancientChestY));
        }
    }
    #endregion

}