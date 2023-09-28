using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayMessages : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public TMP_InputField inputField;

    private string[] messages = { "> Запуск...", "> Сканирование системы…", "> Поиск существ категории «Владыка»….", "> Живых существ категории «Владыка» не обнаружено. ", "> Выполнение протокола «TQL4Z-97BT5 «Лазарь»»…", "> Генетический материал утерян. Ошибка активации протокола «Лазарь». Переход в аварийный режим.", "> Аварийное сканирование окружающей среды...", "> Обнаружено 1 подходящее существо. В связи ошибкой активации протокола «Лазарь» будет активирован протокол «Преемник».", "> Запуск протокола «OVVKY-YM819 “Преемник“».", "Как вас зовут?" };
    private string[] messages2 = {"> Протокол «Преемник» выполнен успешно. Повторный запуск протокола «Лазарь».", " В связи с активацией протокола «Преемник» выполняю активацию протокола «Наставник».", "> Протокол «KLINX-M4IB5  «Наставник» выполнен успешно.", "> Конструирование тела завершено. Запуск систем жизнедеятельности…", "> Системы жизнедеятельности запущены. ", "> Протокол «KLINX-M4IB5  «Наставник» выполнен успешно. Активация импульса перехода…" };
    private int currentindex = 0;
    private int currentindex2 = 0;

    void Start()
    {
        StartCoroutine(DisplayMessagesWithDelay());
        inputField.onEndEdit.AddListener(SeterName);

    }

    IEnumerator DisplayMessagesWithDelay() 
    {
        while (currentindex < messages.Length) 
        {
            
            //messageText.text += messages[currentindex] + "\n";
            //yield return new WaitForSeconds(3f);           
            //currentindex++;

            foreach (char letter in messages[currentindex].ToCharArray())
            {

                messageText.text += letter;
                yield return new WaitForSeconds(0.01f);
            }
            yield return new WaitForSeconds(2.4f);
            messageText.text += "\n";
            currentindex++;



        }
        if (currentindex >= messages.Length) 
        {
        inputField.gameObject.SetActive(true);
        }
       



    }


    IEnumerator DisplayMessagesWithDelay2()
    {
        while (currentindex2 < messages2.Length)
        {

            //messageText.text += messages2[currentindex2] + "\n";
            //yield return new WaitForSeconds(3f);
            //currentindex2++;

            foreach (char letter in messages2[currentindex2].ToCharArray())
            {

                messageText.text += letter;
                yield return new WaitForSeconds(0.01f);
            }

            yield return new WaitForSeconds(2.4f);
            messageText.text += "\n";
            currentindex2++;


        }
        if(currentindex2 >= messages2.Length) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



    void SeterName(string text) 
    {
        NamePersons.namePerc = text;
        Debug.Log("Name is set" + NamePersons.namePerc);
        inputField.gameObject.SetActive(false);
        messageText.text = "> Статус «Владыка» успешно присвоен " + text + "\n";
        //currentindex2 = 0;
        StartCoroutine(DisplayMessagesWithDelay2());


    }



}
