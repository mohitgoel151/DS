package com.mohit.string.manupulation;

import org.junit.Test;
import static org.junit.Assert.*;

public class LexoGreaterSubstringTest {
    
    LexoGreaterSubstring lexo = new LexoGreaterSubstring();
    
    @Test
    public void test() {
//      abc -> bc
//      sst -> st
//      ssat -> t
//      dcbdcbx -> dcbx
//      dcbdcbax -> x
        
        assertEquals("result not correct", "bc", lexo.getResult("abc"));
        assertEquals("result not correct", "st", lexo.getResult("sst"));
        assertEquals("result not correct", "t", lexo.getResult("ssat"));
        assertEquals("result not correct", "dcbx", lexo.getResult("dcbdcbx"));
        assertEquals("result not correct", "x", lexo.getResult("dcbdcbax"));
    }

}
