# -*- coding: utf-8 -*-
"""
Created on Fri Apr 22 02:50:36 2022

@author: marky
"""

import qrcode
a=0
img = qrcode.make("Mechatronics")

f=open("output.png","wb")
img.save(f)
f.close()