using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceRecog : MonoBehaviour
{

    [SerializeField]
    private string[] m_Keywords;

    private KeywordRecognizer m_Recognizer;
    public GameObject dinosaur;
    public GameObject butterfly;
    public GameObject skeleton;
    public GameObject zombies;
    public GameObject tiger;
    public GameObject rabbit;
    public GameObject robot;
    public GameObject horse;
    public GameObject soldier;

    void Start()
    {

        m_Keywords = new string[18];
        m_Keywords[0] = "dinosaur";
        m_Keywords[1] = "butterfly";
        m_Keywords[2] = "skeleton";
        m_Keywords[3] = "zombies";
        m_Keywords[4] = "tiger";
        m_Keywords[5] = "rabbit";
        m_Keywords[6] = "robot";
        m_Keywords[7] = "horse";
        m_Keywords[8] = "soldier";
        m_Keywords[9] = "remove dinosaur";
        m_Keywords[10] = "remove butterfly";
        m_Keywords[11] = "remove skeleton";
        m_Keywords[12] = "remove zombies";
        m_Keywords[13] = "remove tiger";
        m_Keywords[14] = "remove rabbit";
        m_Keywords[15] = "remove robot";
        m_Keywords[16] = "remove horse";
        m_Keywords[17] = "remove soldier";
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();
        
    }
  
    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
       if (args.text == m_Keywords[0])
        {
            Instantiate(dinosaur, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[1])
        {
            Instantiate(butterfly, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[2])
        {
            Instantiate(skeleton, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[3])
        {
            Instantiate(zombies, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[4])
        {
            Instantiate(tiger, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[5])
        {
            Instantiate(rabbit, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[6])
        {
            Instantiate(robot, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[7])
        {
            Instantiate(horse, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[8])
        {
            Instantiate(soldier, transform.position + (transform.forward * 3), transform.rotation);
        }
        if (args.text == m_Keywords[9])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy2");
            foreach (GameObject enemy2 in enemies)
                GameObject.Destroy(enemy2);
        }
        if (args.text == m_Keywords[10])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy1");
            foreach (GameObject enemy1 in enemies)
                GameObject.Destroy(enemy1);
        }
        if (args.text == m_Keywords[11])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy3");
            foreach (GameObject enemy3 in enemies)
                GameObject.Destroy(enemy3);
        }
        if (args.text == m_Keywords[12])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy4");
            foreach (GameObject enemy4 in enemies)
                GameObject.Destroy(enemy4);
        }
        if (args.text == m_Keywords[13])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy5");
            foreach (GameObject enemy5 in enemies)
                GameObject.Destroy(enemy5);
        }
        if (args.text == m_Keywords[14])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy6");
            foreach (GameObject enemy6 in enemies)
                GameObject.Destroy(enemy6);
        }
        if (args.text == m_Keywords[15])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        if (args.text == m_Keywords[16])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy7");
            foreach (GameObject enemy7 in enemies)
                GameObject.Destroy(enemy7);
        }
        if (args.text == m_Keywords[17])
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy8");
            foreach (GameObject enemy8 in enemies)
                GameObject.Destroy(enemy8);
        }
    }

    
}
