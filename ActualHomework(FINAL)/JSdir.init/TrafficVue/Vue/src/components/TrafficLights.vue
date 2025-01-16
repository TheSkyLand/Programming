<template>
<div class="traffic"
    :style="[`background: ${active}`]"
>
</div>
</template>

<script setup>
defineProps({
    active: {
        type: String,
        required: true
    }
})
import { ref } from 'vue'
</script>

<style lang="scss" scoped>
.traffic
{
    display: inline-block;
    width: 100px;
    height: 100px;
    border: 1px solid black;
    border-radius: 50%;
    background-color:  color ;
    margin: 5px 5px 5px 5px;
}
</style>