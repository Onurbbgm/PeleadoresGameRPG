using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class GameText1 : MonoBehaviour
{

    private Text text;
    int countPernaAberta;
    int countUpdate;
    int fontSize;
    //private GUIStyle guiStyle = new GUIStyle();
    private LevelManager levelManager;
    //m - moretto, b - badalotti, t - tormen
    private enum States
    {
        familias, moretto, badalotti, tormen,
        m_ajuda_tormen, m_joga_play,
        m_unirseBadalotti, m_unirB_trairBada, m_ataqueBada, m_defesaBada,
        m_unirB_irAtlantico,
        m_tormemParaSempre, m_fechaAsPernas, m_deixaPernaAberta, m_conitnuarLutaMestre, m_limiteCount, m_chutaMeste, m_chutaCP, m_chutaRodolfo, m_passaJoao,
        t_puteiro, t_investigarAssassinato, t_simPuteiro, t_naoPuteiro,
        b_escutarRodolfo, b_chutarLM, b_estrategiaRodolfoCP, b_sacrificarRodolfo, b_sacrificarCP,
        b_escutarMestre, b_fecharPernas, b_irAoMestre, b_chutarEsmeraldaIgor, b_chutarBolaIgor,
        continuaTexto_1, continuaTexto_2, continuarTexto_3, continuaTexto_4, continuaTexto_5, continuaTexto_6, continuaTexto_7
    };
    private States myState;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        countPernaAberta = 0;
        countUpdate = 0;
        text.fontSize = 30;
        myState = States.familias;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);
        if (myState == States.familias)
        {
            familias();
        }
        else if (myState == States.moretto)
        {
            moretto();
        }
        else if (myState == States.badalotti)
        {
            badalotti();
        }
        else if (myState == States.tormen)
        {
            tormen();
        }
        else if (myState == States.m_ajuda_tormen)
        {
            m_ajuda_tormen();
        }
        else if (myState == States.m_joga_play)
        {
            m_joga_play();
        }
        else if (myState == States.m_unirseBadalotti)
        {
            m_unirseBadalotti();
        }
        else if (myState == States.m_unirB_trairBada)
        {
            m_unirB_trairBada();
        }
        else if (myState == States.m_ataqueBada)
        {
            m_ataqueBada();
        }
        else if (myState == States.m_defesaBada)
        {
            m_defesaBada();
        }
        else if (myState == States.m_unirB_irAtlantico)
        {
            m_unirB_irAtlantico();
        }
        else if (myState == States.m_tormemParaSempre)
        {
            m_tormemParaSempre();
        }
        else if (myState == States.m_fechaAsPernas)
        {
            m_fechaAsPernas();
        }
        else if (myState == States.m_deixaPernaAberta)
        {
            m_deixaPernaAberta();
        }
        else if (myState == States.m_conitnuarLutaMestre)
        {
            m_conitnuarLutaMestre();
        }
        else if (myState == States.m_limiteCount)
        {
            m_limiteCount();
        }
        else if (myState == States.m_chutaMeste)
        {
            m_chutaMeste();
        }
        else if (myState == States.m_chutaCP)
        {
            m_chutaCP();
        }
        else if (myState == States.m_chutaRodolfo)
        {
            m_chutaRodolfo();
        }
        else if (myState == States.m_passaJoao)
        {
            m_passaJoao();
        }
        else if (myState == States.t_puteiro)
        {
            t_puteiro();
        }
        else if (myState == States.t_investigarAssassinato)
        {
            t_investigarAssassinato();
        }
        else if (myState == States.t_simPuteiro)
        {
            t_simPuteiro();
        }
        else if (myState == States.t_naoPuteiro)
        {
            t_naoPuteiro();
        }
        else if (myState == States.b_escutarRodolfo)
        {
            b_escutarRodolfo();
        }
        else if (myState == States.b_chutarLM)
        {
            b_chutarLM();
        }
        else if (myState == States.b_estrategiaRodolfoCP)
        {
            b_estrategiaRodolfoCP();
        }
        else if (myState == States.b_sacrificarRodolfo)
        {
            b_sacrificarRodolfo();
        }
        else if (myState == States.b_sacrificarCP)
        {
            b_sacrificarCP();
        }
        else if (myState == States.b_escutarMestre)
        {
            b_escutarMestre();
        }
        else if (myState == States.b_fecharPernas)
        {
            b_fecharPernas();
        }
        else if (myState == States.b_irAoMestre)
        {
            b_irAoMestre();
        }
        else if (myState == States.b_chutarEsmeraldaIgor)
        {
            b_chutarEsmeraldaIgor();
        }
        else if (myState == States.b_chutarBolaIgor)
        {
            b_chutarBolaIgor();
        }
        else if (myState == States.continuaTexto_1)
        {
            continuaTexto_1();
        }
        else if (myState == States.continuaTexto_2)
        {
            continuaTexto_2();
        }
        else if (myState == States.continuarTexto_3)
        {
            continuarTexto_3();
        }
        else if (myState == States.continuaTexto_4)
        {
            continuaTexto_4();
        }
        else if (myState == States.continuaTexto_5)
        {
            continuaTexto_5();
        }
        else if (myState == States.continuaTexto_6)
        {
            continuaTexto_6();
        }
        else if (myState == States.continuaTexto_7)
        {
            continuaTexto_7();
        }
    }
    IEnumerator LoadLevel(string level, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        levelManager.LoadLevel(level);

    }

    #region State handler methods
    void b_chutarBolaIgor()
    {
        text.text = "A bola passa pelo meio das pernas de Igor, você e seus companheiros todos começam a bater nele sem parar. Moretto resgata seu companheiro no meio da confusão e decide bater em retirada.\n" +
            "Vocês retornam para o Clube do Comercio, agora você planeja uma expedição para o Atlântico, você sabe que a viajem vai ser longa e árdua, mas a recompensa pode lhe garantir a dominância do mundo inteiro.\nContinua em...\n\n" +
            "<size=40><color=yellow><b>Peleadores - A Clash of the Peleias</b></color></size>\n\n" +
            "<color=red>Precione J para jogar novamente</color>";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void b_chutarEsmeraldaIgor()
    {
        text.text = "Logo que você chuta a Esmeralda, Bruno comanda ela para voltar para o meio das suas pernas, desta vez você não esta preparado e ela passa no meio. Todos começam a bater em você incontrolavelmente!\n" +
            "Felizmente você e seus companheiros conseguem escapar quando Ícaro CP solta uma bomba de gas e distrai os seus oponentes.\n" +
            "Vocês retornam para o Clube do Comercio, agora você planeja uma expedição para o Atlântico, você sabe que a viajem vai ser longa e árdua, mas a recompensa pode lhe garantir a dominância do mundo inteiro.\nContinua em...\n" +
             "<size=40><color=yellow><b>Peleadores - A Clash of the Peleias</b></color></size>\n" +
            "<color=red>Precione J para jogar novamente</color>";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void b_irAoMestre()
    {
        text.text = "Quando você começa a ir em direção de Mestre, Bruno comanda Esmeralda a mudar sua trajetória. Agora a bola vem em sua direção e passa no meio da suas pernas.\n" +
            "Todos começam a bater em você incontrolavelmente.\n" +
            "Felizmente você e seus companheiros conseguem escapar quando Ícaro CP solta uma bomba de gas e distrai os seus oponentes.\n" +
            "Vocês retornam para o Clube do Comercio, agora você planeja uma expedição para o Atlântico, você sabe que a viajem vai ser longa e árdua, mas a recompensa pode lhe garantir a dominância do mundo inteiro.\nContinua em...\n" +
             "<size=40><color=yellow><b>Peleadores - A Clash of the Peleias</b></color></size>\n" +
            "<color=red>Precione J para jogar novamente</color>";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void b_fecharPernas()
    {
        text.text = "Quando a bola esta quase chegando ao Mestre Bruno comanda ela para ir até você numa velocidade incrível, felizmente suas pernas estão fechadas e você previne o pior.\n" +
            "Agora é sua vez, Igor esta próximo de você e desprevenido, o que você deseja fazer:\n" +
            "<color=red>Preciona E para chutar Esmeralda em direção a Igor ou B para chutar sua bola em direção a Igor</color>";
        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.b_chutarEsmeraldaIgor;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.b_chutarBolaIgor;
        }
    }

    void b_escutarMestre()
    {
        text.text = "Você junto a Mestre viaja ate o Centro disfarçado para não ser reconhecido pelas forças de Tormen, a rumores que Bruno Moretto o Justo, líder da casa Moretto e protetor do Norte e governador do reino Estar do Chile, esta no Centro para se encontrar com o Rei Tormen.\n" +
            "Justo vocês estas acompanhados por Ícaro o CP, um dos maiores boleiros do mundo.\n" +
            "Vocês conseguem interceptar o grupo dos Morettos antes deles alcançarem o Castelinho, residência do Rei. O grupo consiste de Bruno, Joao o Anao, alto conselheiro de Bruno, Berga o Risada um dos homens mais fortes do mundo e Igor o Malandro considerado um mestre manipulador.\n" +
            "Bruno - \"<b>O que vocês estão fazendo aqui?</b>\"\n" +
            "Bada - \"<b>Acho que o Rei já deu o que tinha que dar, ele é um trapaceiro e um enganador, esta na hora de você se juntar a uma aliança que tem um poder real e pode mudar esse mundo para sempre! Junte-se a nós e sera muito bem recompensado!</b>\"\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_7;
        }
    }
    void continuaTexto_7()
    {
        text.text =
            "Bruno - \"<b>Então é você que esta por trás da tentativa de assassinato ao Rei! Admite Bada tu só quer matar ele porque tu acha que ele roubou no truco!</b>\"\n" +
            "Bada - \"<b>Não é só por isso!</b>\"\n" +
            "Bruno - \"<b>Chega! Isso acaba aqui! Nunca irei trair o meu Rei!</b>\"\n" +
            "Bruno e seus companheiros puxam suas bolas, para começar o futsoco. Bruno tem uma bola magica extremamente perigosa chamada Esmeralda, pela sua cor, que pode alterar sua direção a qualquer momento quando comandada por seu mestre.\n" +
            "Bruno da um dos seus chutes mais poderosos usando uma de suas estratégias clássicas chamada de Calculada do Moretto!\n" +
            "A bola esta indo em direção ao Mestre, mas com Esmeralda você nunca sabe o que pode acontecer, o que você deseja fazer?\n" +
            "<color=red>Precione F para fechar as pernas ou M para ir até o Mestre</color>";
        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.b_fecharPernas;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.b_irAoMestre;
        }
    }
    void b_sacrificarCP()
    {
        text.text = "O plano é posto em ação, CP deixa a bola passar no meio de suas pernas, logo Longines Malinowski toma uma forma solida para atacar e tomar sua alma.\n" +
            "Conforme Longines se aproxima de sua vitima, você rapidamente toma controle da bola e chuta em sua direção, Longines estando distraindo sugando a alma de Ícaro deixa a bola passar no meio de suas pernas, você e Rodolfo enchem ele de soco sem piedade.\n" +
            "Longines Malinowski - \"<b>Vocês podem ter me derrotado dessa vez, mas não foi a ultima vez que nos encontraremos!!!</b>\"\n" +
            "Com isso seu espirito desaparece, mas infelizmente já é tarde de mais e CP teve sua alma sugada pela energia da floresta.\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_6;
        }
    }

    void b_sacrificarRodolfo()
    {
        text.text = "O plano é posto em ação, Rodolfo deixa a bola passar no meio de suas pernas, logo Longines Malinowski toma uma forma solida para atacar e tomar sua alma.\n" +
            "Conforme Longines se aproxima de sua vitima, você rapidamente toma controle da bola e chuta em sua direção, Longines estando distraindo sugando a alma de Rodolfo deixa a bola passar no meio de suas pernas, você e CP enchem ele de soco sem piedade.\n" +
            "Longines Malinowski - \"<b>Vocês podem ter me derrotado dessa vez, mas não foi a ultima vez que nos encontraremos!!!</b>\"\n" +
            "Com isso seu espirito desaparece, mas infelizmente já é tarde de mais e Rodolfo teve sua alma sugada pela energia da floresta.\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_6;
        }

    }
    void continuaTexto_6()
    {
        text.text = "A jornada até o Atlântico esta apenas começando, a guerra se aproxima!\nContinua em...\n\n\n" +
            "<size=40><color=yellow><b>Peleadores - A Clash of the Peleias</b></color></size>\n\n\n" +
            "<color=red>Precione J para jogar novamente</color>";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }
    void b_estrategiaRodolfoCP()
    {
        text.text = "CP - \"<b>Ele é um fantasma, não tem como nós dar soco nele, então nunca poderemos vencer!</b>\"\n" +
            "Rodolfo - \"<b>Se a bola passar em um de nos ele vai ter que dar soco, para isso vai ter que tomar uma forma solida. Nesse momento devemos atacar!</b>\"\n" +
            "Bada - \"<b>Mas para isso um de nós vai ter que deixar a bola passar e essa pessoa vai ter a alma pressa na Floresta Perdida para sempre e mais vamos ter que ser muito rápido para logo que a bola passar chutar de volta em direção a Longines! É muito arriscado!</b>\"\n" +
            "CP - \"<b>É nossa unica chance, vamos ter que fazer isso Bada. Você tem que escolher um de nos para se sacrificar!</b>\"\n" +
            "<color=red>Precione R para SACRIFICAR RODOLFO ou I para SACRIFICAR CP</color>";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.b_sacrificarRodolfo;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.b_sacrificarCP;
        }
    }

    void b_chutarLM()
    {
        text.text = "A bola passa no meio das pernas de Longines Malinowski, mas como ele é um fantasma seus socos atravessam ele, como se não fossem nada.\n" +
            "Bada - \"<b>Não temos como vencer se nossos socos não funcionam!</b>\"\n" +
            "Você toma o controle da bola novamente o que deseja fazer:\n" + "<color=red>Precione C para chutar ela em direção a Longines Malinowski ou E para montar uma estrategia com Rodolfo e CP</color>";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.b_chutarLM;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.b_estrategiaRodolfoCP;
        }
    }

    void b_escutarRodolfo()
    {
        text.text = "Você, Rodolfo e Icaro CP começam a viajem ate o reino de Atlântico, um lugar esquecido e muito perigoso, cheio de criaturas magicas.\n" +
            "Quando vocês estão no meio do caminho, começam a escutar sons estranho na Floresta Perdida, mais conhecida como Parque Longines Malinowski.\n" +
            "Rodolfo - \"<b>Lendas dizem que o fantasma de Longines Malinowski esta preso nesta floresta e que ele testa os que passam por aqui para ver se eles merecem chegar até o Atlântico.</b>\"\n" +
            "CP - \"<b>São apenas lendas. Duvido ...</b>\"\n" +
            "Um som muito forte, interrompe CP.\nDas sombras sai...\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_5;
        }
    }
    void continuaTexto_5()
    {
        text.text = "O FANTASMA DE LONGINES MALINOWSKI!\n" +
            "Longines Malinowski - \"<b>Só verdadeiros Peleadores podem passar por este lugar!Vocês devem me mostrar suas habilidades em uma partida de futsoco!Se falharem suas almas ficaram presas aqui para sempre!A não ser que você seja ruivo, porque ruivos não tem alma.</b>\"\n" +
            "Bada - \"<b>Não temos escolha, vamos ter que jogar contra ele!</b>\"" +
            "A partida começa Longines invoca uma bola fantasma para jogar. Ele posiciona e chuta em sua direção, você consegue dominar ela.\n" +
            "Você tem o controle da bola o que deseja fazer:\n" + "<color=red>Precione C para chutar ela em direção a Longines Malinowski ou E para montar uma estrategia com Rodolfo e CP</color>";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.b_chutarLM;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.b_estrategiaRodolfoCP;
        }

    }
    void t_naoPuteiro()
    {
        text.text = "VOCÊ QUIS DIZER IR PARA UM PUTEIRO?\n" +
           "<color=red>Precione S para SIM e N para NÃO</color>";
        if (Input.GetKeyDown(KeyCode.S))
        {
            text.fontSize = 23;
            myState = States.t_simPuteiro;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            text.fontSize = text.fontSize + 5;
            myState = States.t_naoPuteiro;
        }
    }

    void t_simPuteiro()
    {
        text.text = "Você é morto por uma prostituta asfixiado achando que era parte do programa. Parabéns!\n" +
            "<color=red>Precione J para JOGAR NOVAMENTE</color>";
        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void t_investigarAssassinato()
    {
        text.text = "Você quis dizer ir para um puteiro?\n" +
            "<color=red>Precione S para SIM e N para NÃO</color>";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.t_simPuteiro;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.t_naoPuteiro;
        }
    }

    void t_puteiro()
    {
        text.text = "Cove é morto por uma prostituta asfixiado achando que era parte do programa. Parabéns!\n" +
            "<color=red>Precione J para JOGAR NOVAMENTE</color>";
        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void m_passaJoao()
    {
        text.text = "João pega a bola e chuta numa velocidade inacreditável em direção a Mestre, ele não esperava por isso e a bola passa pelo meio da suas pernas. Você e seus companheiros começam a bater sem para em Mestre, mas mesmo assim ele consegue acabar escapando junto com seus companheiros no meio da confusão.\n" +
            "Você vai para o Castelinho e se direcionada diretamente a sala do trono.\n" +
            "Cenorinha pede o que era a confusão acontecendo la fore e você explica a situação.\n" +
            "Cenorinha - <b>\"Então é obvio o responsável pela tentativa de assassinato a minha vida! Leonardo Badalotti é o responsável! Provavelmente ele tem inveja de minhas habilidades no truco!</b>\"\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_2;
        }
    }
    void continuaTexto_2()
    {
        text.text = "Você concorda com a interpretação do rei, algo deve ser feito, os ataques não pararão até que somente um seja o Rei de Erechim.\n" +
            "Paini o Sábio, conselheiro do rei propõem cautela e uma estratégia defensiva.\n" +
            "Augusto o Bêbado, não pare esta preocupado com a situação e continua enchendo a cara.\n" +
            "Bovo o ..., propōem  um ataque imediato as forças de Badalotti, enquanto eles nao esperam. Luciano o ... concorda com a estratégia de Bovo.\n" +
            "Cenourinha - <b>\"Eu não sei o que fazer Bruno, o que você acha?</b>\"\n" +
            "<color=red>Precione A para ir a GUERRA IMEDIATAMENTE ou D para ORGANIZAR UMA DEFESA</color>";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.m_ataqueBada;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.m_defesaBada;
        }
    }

    void m_defesaBada()
    {
        text.text = "O rei escuta o seu conselho e logo começam os preparativos para fortificar o Castelinho e proteger o Centro do inevitável ataque Badalotti!\n" +
            "A guerra sera longa e árdua!\n" +
            "Continua em...\n\n\n" +
            "<size=40><color=yellow><b>Peleadores - A Clash of the Peleias</b></color></size>\n\n\n" +
            "<color=red>Precione J para jogar novamente</color>";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void m_ataqueBada()
    {

        text.text = "O rei escuta o seu conselho e começa os preparativos para atacar os Badalotti e seu reino do Clube do Comercio imediatamente!\n" +
            "A guerra sera longa e árdua!\n" +
            "Continua em...\n\n\n" +
            "<size=40><color=yellow><b>Peleadores - A Clash of the Peleias</b></color></size>\n\n\n" +
            "<color=red>Precione J para jogar novamente</color>";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void m_chutaRodolfo()
    {
        text.text = "Rodolfo consegue o dominio da bola e passa para Mestre.\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.m_conitnuarLutaMestre;
        }
    }

    void m_chutaCP()
    {
        text.text = "CP consegui rapidamente controlar a bola  e passa para Mestre.\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.m_conitnuarLutaMestre;
        }
    }

    void m_chutaMeste()
    {
        text.text = "Mestre fecha rapidamente a perna e agora tem o controle da bola.\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.m_conitnuarLutaMestre;
        }
    }

    void m_deixaPernaAberta()
    {
        if (countPernaAberta >= 3)
        {
            myState = States.m_limiteCount;
        }
        text.text = "QUAL O TEU PROBLEAM, TU NUNCA JOGOU FUTSOCO, TU NAO PODE DEIXAR AS PERNAS ABERTA!\n" +
            "Voce apanha quase ate a morte de Mestre, Rodolfo e Icaro!\n" + "<color=red>Precione SETA DA DIREITA para continuar.</color>";
        if (countUpdate == 0)
        {
            countPernaAberta++;
        }
        countUpdate = 1;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.m_conitnuarLutaMestre;
        }
    }

    void m_limiteCount()
    {
        text.text = "Tu quer morrer mesmo, então tu morreu!\nFIM DE JOGO SEU PUTO!\n\n" + "<color=red>Precione J para jogar novamente</color>";
        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }
    void m_conitnuarLutaMestre()
    {
        countUpdate = 0;
        text.text = "Mestre da um super passe para Rodolfo que chuta a bola de papel em sua direção numa velocidade incrivel.\n" +
            "O que você faz:\n" + "<color=red>Precione F para fechar as pernas ou A para deixar as pernas abertas</color>";
        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.m_fechaAsPernas;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.m_deixaPernaAberta;
        }
    }

    void m_fechaAsPernas()
    {
        text.text = "Muito bem, a bola nao passa pela suas pernas e agora voce esta no controle da situação. Rodolfo esta com a perna aberta e esperando pelos seu chute, Mestre esta confiante e preparado e CP esta posicionado, esperando o lance. Joao esta proximo e pedindo a bola.\n" +
            "O que você deseja fazer:\n" + "<color=red>Precione M para chutar em direção de Mestre</color>\n" + "<color=red>Precione I para chutar em direção de CP</color>\n" +
            "<color=red>Precione R para chutar em direção de Rodolfo</color>\n" + "<color=red>Precione J para passar para João</color>";
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.m_chutaMeste;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.m_chutaCP;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.m_chutaRodolfo;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.m_passaJoao;
        }
    }

    void m_tormemParaSempre()
    {
        text.text = "Bruno - <b>\"Nunca trairei o grande REI CENORINHA!</b>\"" +
            "Nervoso Mestre o desafia para uma partida de futsoco.\n" +
            "Voce aceita e assim começa a batalha.\n" +
            "Mestre da um super passe para Rodolfo que chuta a bola de papel em sua direção numa velocidade incrivel.\n" +
            "<color=red>Precione a seta da direita para começar a batalha</color>";
        //+"O que você faz:\n" + "<color=red>Precione F para fechar as pernas ou A para deixar as pernas abertas</color>";

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            levelManager.LoadLevel("01 - BattleBruno-Mestre");
        }

       //StartCoroutine(LoadLevel("01 - BattleBruno-Mestre", 10f));

        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.m_fechaAsPernas;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.m_deixaPernaAberta;
        }
    }

    void m_unirB_irAtlantico()
    {
        text.text = "Você começa a jornada para o reino perdido de Atlântico, dizem que é cheio de criaturas magicas e poderosas, você é acompanhado pelo grande Mestre, João o Anão, Berga o Risada e por Rodolfo o Mito2018.\n" +
            "Lá vocês devem se encontrar com os Sábios, aparentemente eles e Bada tem algum acordo por troca de informações pela localização da Peleadora.\n" +
            "Será uma longa viagem, ninguém sabe dos perigos que podem acontecer no caminho, ou do quão perigoso Atlântico pode ser.\n" +
            "Continua em..\n\n" +
             "<size=40><color=yellow><b>Peleadores - A Clash of the Peleias</b></color></size>\n" +
            "<color=red>Precione J para jogar novamente</color>";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void m_unirB_trairBada()
    {
        text.text = "Você rápida mente foge do Clube do Comercio e se direciona de volta para o Centro, junto de seus companheiros e se direciona ao Castelinho para contar os acontecimentos ao Rei Cenourinha.\n" +
            "Tormen - \"<b>O que aconteceu? Pensei que você deveria ter chegado muito antes, meus solados falaram que você estava nas proximidade</b>\"\n" +
            "Bruno - \"<b>Meu Rei, fui ate o Clube do Comercio junto com Mestre, falei que me aliaria a eles, para descobrir que tipo de informação poderia extrair. As coisas são piores do que pensávamos. Bada esta em busca da Peleadora e parece que ele esta próximo de encontrar lá</b>\"\n" +
            "Tormen - \"<b>Meu deus! Eu sempre achei que a Peleadora era só um mito! Se ela realmente é real precisamos agir rápido!</b>\"\n" +
            "<color=red>Precione SETA DA DIRETIA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_2;
        }
    }

    void m_unirseBadalotti()
    {
        text.text = "Bruno - \"<b>Acho que vocês tem uma chance real de ganhar essa guerra e de mudar esse mundo pra melhor. Me juntarei a sua casa na guerra que esta por vir!</b>\"\n" +
            "Junto com Mestre e seus companheiros vocês começam a viajar ate o reino do Clube do Comercio casa dos Badalotti.\n" +
            "Ao chegar o reino Leonardo Badalotti o Bada, governado do reino o saudá.\n" +
            "Bada - \"<b>Bem vindo ao nosso reino!Fico feliz com sua escolha, não ira se arrepender, nós iremos destruir Tormen, aquele ladrão no truco, so ganha roubando, e seus seguidores!</b>\"\n" +
            "Bruno - \"<b>Qual o plano de vocês para conquistar um dos reinos mais seguros do mundo? Afinal o Centro não é invadido a mais de 500 anos!</b>\"\n" +
            "<color=red>Precios SETA DA DIREITA para coninuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuarTexto_3;
        }
    }
    void continuarTexto_3()
    {
        text.text = "Bada - \"<b>Não se preocupe com isso temos uma arma secreta, algo que eles nunca vão esperar, eu sei a localização da Peleadora a bola com o maior poder do universo, logo terei ela em meu controle e Tormen não terá chance de vencer essa guerra jamais!</b>\"\n" +
            "Você fica muito surpreso, a Peleadora é considerado por muitos só uma lenda, uma bola com tanto poder que pode ate mudar a realidade do universo! Ninguém sabe de tudo que ela é capaz!\n" +
            "Bada - \"<b>Preciso que você vá ate o reino de Atlântico, o reino esquecido, la se encontrara com os Sábios e eles darão a localização da Peleadora, traga ela a mim e sera muito bem recompensado!</b>\"\n" +
            "O que voce deseja fazer:\n" + "<color=red>Precione T para trair Bada e voltar com essas informações para Tormen ou A para ir para o Atlantico e ajudar Bada</color>";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.m_unirB_trairBada;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.m_unirB_irAtlantico;
        }
    }
    void m_joga_play()
    {
        text.text = "Sua escolha levou a Vitinho Tormen morrer asfixiado por uma prostituta contrata por Guilherme Badalotti o Mestre, servo do governador do reino do Clube do Comercio, Leonardo Badalotti o Bada, que quer tomar o mundo de Erechim para si mesmo.\n\n" +
            "FIM DE JOGO\n\n" + "<color=red>Precione J para Jogar novamente</color>";
        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.familias;
        }
    }

    void m_ajuda_tormen()
    {
        text.text = "Você viaja em direção a capital, uma viajem longa e árdua, você enfrenta varias adversidades no caminho mas com a companhia dos seus maiores aliados, Berga o Risadinha, Igor o Malandro e Joao o Anao nada é um desafio grande o suficiente.\n" +
            "Voces finalmente chega ao Centro.\n" + "Ao chegar você imediatamente vai em direçao ao Castelinho, residência de Vitor Tormen, mas no caminho você é parado por ninguém menos que Guilherme Badalotti o MESTRE.\n" +
            "Mestre esta com um pequeno grupo de guerreiros, incluindo Rodolfo o Mito2018 e Icaro o CP.\n" +
            "Ele foi enviado por Leonardo Badalotti para convencer voce a se juntar a familia Badalotti na guerra que esta por vir.\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_1;
        }
    }

    void continuaTexto_1()
    {
        text.text = "Mestre - <b>\"Ta, tu vai se juntar a nós ou não? O Tormen ta pra cair, nós vamos acabar com aquele posto e tomar conta dessa cidade, quer dizer reino!</b>\"\n" +
           "O que você deseja fazer:\n" + "<color=red>Precione B para se juntar aos Badalotti ou T para manter sua lealdade à Vitor Tormen</color>";
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.m_unirseBadalotti;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.m_tormemParaSempre;
        }
    }

    void tormen()
    {
        text.text = "Você é o rei de Erechim, apesar de ter herdado o trono do Seu Alenca o rei Louco, alguns dias atras houve um atentado a sua vida, por isso você envia uma carta de ajuda a Bruno Moretto o Justo.\n" +
            "Apesar da ameaça a sua vida você, esta cogitando ir para um puteiro, o que você deseja fazer:\n" +
            "<color=red>Precione P para ir ao puteiro ou I para investigar a tentativa de assassinato a sua viada.</color>";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.t_puteiro;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.t_investigarAssassinato;
        }
    }

    void badalotti()
    {
        text.text = "Você é Leonardo Badalotti o Bada, o se auto proclamado rei do Leste, alguns dias atras você tramou uma tentativa de assassinato ao rei de Erechim Vitinho Tormen o Trouxa, já que o seu objetivo é humilhar e destruir ele, pois ele roubou no truco de você, como sempre.\n" +
            "Infelizmente sua tentativa falho e agora uma guerra esta por vir.\n" +
            "Você tem informações importantes sobre uma arma lendária de poderes inimagináveis chamada a Peleadora, a bola mais poderosa do universo.\n" +
            "De acordo com seus informantes os Sabios que vivem no reino perdido de Atlântico tem a localização da bola.\n" +
            "Você manda uma carta para os Sabios dizendo que para qualquer coisa para tomar posse da Peleadora. Não muito tempo depois eles respondem dizendo que se forem ajudados em uma missão especial podem lhe dar a informação que busca.\n" +
            "<color=red>Precione SETA DA DIREITA para continuar</color>";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.continuaTexto_4;
        }
    }

    void continuaTexto_4()
    {
        text.text = "Você concorda com a proposta dos Sabios, mesmo não sabendo qual sera a missão.\n" +
            "Guilherme Badalotti, o Mestre propõem que vá em busca de mais ajuda, antes de ir a uma busca de algo que pode nem existir, tentando convencer a casa Moretto a se aliar na batalha que esta por vir.\n" +
            "Já Rodolfo o Mito2018 acha que é mais importante ir para o Atlântico em busca da Peleadora, uma arma que ele acha que poderá mudar o rumo da guerra.\n" +
            "O que você deseja vazer:\n" +
            "<color=red>Precione R para seguir o conselho de Rodolfo ou M para seguir o conselho de Mestre</color>";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.b_escutarRodolfo;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.b_escutarMestre;
        }
    }

    void moretto()
    {
        text.text = "O reino de Moretto, localizado no Norte de Erechim, chamado Estar do Chile, liderado por Bruno Moretto o Justo, considerado um homem correto e leal ao rei de Erechim, Tormen.\n" +
            "Um dos seus vassalos Joao Dill o Anão, chega com uma grande noticia, houve um atentado a vida do rei Vitinho Tormen o Cenorinha, que lia: \n" +
            "\"Precisamos de voce no Centro, temo minha vida, voce é minha ultima salvaçao\"\n" +
            "O que você deseja fazer:\n" +
            "<color=red>Precione A para ir ajudar Tormen e P para ficar em casa jogando play</color>";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.m_ajuda_tormen;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.m_joga_play;
        }
    }

    void familias()
    {
        text.text = "Num mundo muito distante, chamado Erechim, viviam 3 famílias que controlavam os diferentes territórios do mundo.\n" +
            "Os Morettos, protetores do Norte e governadores de Estar do Chile por 300 anos.\n" +
            "Os Badalotti governadores do Clube do Comercio, costumavam a ser um reino independente com seu próprio rei até a grande Guerra dos Truco, onde depois de perderem uma partida de truco para os Tormens tiveram que submeter o reino. Por 150 anos eles proclamam que a partida foi roubada e que merecem independencia.\n" +
            "E os Tormen, que controlam todo o mundo de Erechim por mais de 150 anos, sendo uma das familias mais fortes a terem reinado este mundo.\n" +
            "Esta historia começa com uma tentativa de assassinato falhado a vida do Rei Vitor Tormen o Cenourinha\n" +
            "Escolha qual familia seguir: \n" + "<color=red>Precione M para Morettos, T para Tormen e B para Badalotti</color>";
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.moretto;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.tormen;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.badalotti;
        }

    }

    #endregion

    
}
