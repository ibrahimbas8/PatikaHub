package com.company;

public class Main {

    public static void main(String[] args) {
        boolean asalMi=false;
        for (int i=2; i<100; i++){
            for (int j=2; j<i; j++){
                if (i%j==0){
                    asalMi=false;
                    break;
                }
                else {
                    asalMi = true;
                }
            }
            if (asalMi == true){
                System.out.println(i);
            }
            asalMi=false;
        }
    }
}
