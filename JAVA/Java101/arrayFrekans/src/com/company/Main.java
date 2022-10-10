package com.company;

public class Main {

    public static void main(String[] args) {
	    int[] dizi = {10, 20, 20, 10, 10, 20, 5, 20};
        int [] fr = new int [dizi.length];

        int varMi = -1;
        for(int i = 0; i < dizi.length; i++){
            int sayac = 1;
            for(int j = i+1; j < dizi.length; j++){
                if(dizi[i] == dizi[j]){

                    sayac++;
                    fr[j] = varMi;
                }
            }
            if(fr[i] != varMi)
                fr[i] = sayac;
        }

        System.out.println("Tekrar Sayilari  ");
        for(int i = 0; i < fr.length; i++){
            if(fr[i] != varMi)
                System.out.println(dizi[i] + " sayısı " + fr[i] + " kere tekrar edildi ");
        }
    }
}
