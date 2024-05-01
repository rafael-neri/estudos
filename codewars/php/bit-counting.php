<?php

function countBits($n)
{
   return strlen(str_replace("0", "", decbin($n)));
}
