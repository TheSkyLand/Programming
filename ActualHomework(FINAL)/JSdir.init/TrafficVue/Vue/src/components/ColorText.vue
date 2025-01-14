<template>
    <div :style="[`color: ${colorText}`]">
        text = {{ mainText }}
    </div>
</template>

<script setup>
defineProps({
    mainText: {
        type: String,
        required: true
    },
    colorText: {
        type: Number,
        required: true,
    }
})
</script>

<style lang="scss" scoped>
</style>
