using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BlowtorchController : MonoBehaviour
{
    public bool held = false;
    public bool firing = false;

    [SerializeField]
    GameObject NormalFiringParticle;
    public Transform ParticleAnchor;
    GameObject currentFiredParticle;


    void Update()
    {

    }

    public void setHeld(bool state)
    {
        held = state;
        if (!held)
        {
            firing = false;
            
        }
    }

    public void setFiring(bool state)
    {
        if (held)
        {
            firing = state;
            if (firing)
            {
                currentFiredParticle = Instantiate(NormalFiringParticle, ParticleAnchor);
            }
            else
            {
                ParticleSystem particle = currentFiredParticle.GetComponent<ParticleSystem>();
                var main = particle.main;
                var emission = particle.emission;

                main.loop = false;
                emission.rateOverTime = 0;
            }
        }
        
    }
}