using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema4 : MonoBehaviour
{
    public int cantidadDeUnidades;
    int cantidadDeDiasTotales;
    public int cantidadDeDiasdeLluvia;
    public int cantidadDeDiasNormales;
   int costoTotalCombustible;

    // Start is called before the first frame update
    void Start()
    {
        cantidadDeDiasTotales = cantidadDeDiasNormales + cantidadDeDiasdeLluvia;
        

        if (cantidadDeDiasTotales > 5 || cantidadDeDiasdeLluvia > 0  )
        {
            Debug.Log("Error");
        }
       else
       {
            Debug.Log("Una flota de " +cantidadDeUnidades+ "unidades trabajando durante" +cantidadDeDiasTotales+ " días implicará un gasto de " +costoTotalCombustible+
             "pesos en concepto de combustible");
      }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
