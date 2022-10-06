<template>
    <AccountLogin v-if="login" />
    <AccountRegister v-if="register" />
</template>

<script>
export default {
    data() {
        return {
            login: true,
            register: false
        }
    },
    methods:{
        testP(){
            console.log('parent')
        }
    }
}
</script>