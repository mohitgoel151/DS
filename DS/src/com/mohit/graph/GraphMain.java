package com.mohit.graph;

import com.mohit.design.Singleton;

public class GraphMain {

    public static void main(String[] args) {
        PathWithWeightK pathWithKWeight = new PathWithWeightK();
        //pathWithKWeight.execute();
        
        System.out.println("before singleton");
        Singleton singleton = Singleton.getInstance();

    }

}
