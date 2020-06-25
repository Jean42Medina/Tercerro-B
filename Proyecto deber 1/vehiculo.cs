using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_deber_1
{
    class vehiculo
    {
    public static int velocidad;
    public static String motor;
    public static int tanqueGasolina;
    
    public int aumentar(){
        if(velocidad >=0 && velocidad <=200){
            velocidad = velocidad+10;
            return velocidad;
        }else{
            return 200;
        }
    }
    
    public int disminuir(){
        if(velocidad >=0){
            velocidad = velocidad-5;
        }
        return velocidad;
    }
    
    public int frenar(){
        if(velocidad >=0){
            velocidad =0;
        }
        return velocidad;
    }
    
    public String encender(){
        if(motor=="Apagado"){
            motor="Encendido";
        } else { 
        }
        return motor;
    }
    
    public String apagar(){
        if(motor=="Encendido"){
            motor="Apagado";
        } else { 
        }
        return motor;
    }
    
    public int llenar(int gasolina){
        if(tanqueGasolina >=0 && tanqueGasolina <=10){
            tanqueGasolina = tanqueGasolina+gasolina;
        } else { 
        }
        return tanqueGasolina;
    }
    
    public int vaciar(){
        if(tanqueGasolina > 0){
            tanqueGasolina = tanqueGasolina-1;
            return tanqueGasolina;
        } else {
            return 0;
        }
    }


    }
}
