using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LampadaFalhando : MonoBehaviour
{
    public new Light light;
    public GameObject emissiveObject;
    public AudioSource audioSource;
    public AnimationCurve animationCurve;
    public Color color;
    public float multiplyIntensity = 1.0f;

    public WrapMode wrapmode = WrapMode.PingPong;

    private Material emissiveMaterial;

    private void Start()
    {
        light.enabled = false;

        this.animationCurve.postWrapMode = this.wrapmode;
        this.emissiveMaterial = emissiveObject.GetComponent<Renderer>().material;

        this.light.color = this.color;

        this.emissiveMaterial.SetColor("_EmissionColor", this.color * 0);
    }
    void Update()
    {
        if (Tempo.contagem <= Tempo.tempoAcabando)
        {
            light.enabled = true;

            float value = animationCurve.Evaluate(Time.time);

            this.light.intensity = value * multiplyIntensity;
            this.emissiveMaterial.SetColor("_EmissionColor", this.color * value);

            if (value >= 0.9 && !this.audioSource.isPlaying)
            {
                this.audioSource.Play();
            }
        }
    }
}
