<template>
    <div class="flex justify-center items-center h-full">
        <div class="w-screen px-10">
            <form>
                <div class="form-group mb-6">
                    <label for="exampleInputEmail1" class="form-label inline-block mb-2 text-white">
                        Account
                    </label>
                    <input type="text"
                        class="w-full px-3 py-1.5 text-base text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0 focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none"
                        id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email" />
                </div>
                <div class="form-group mb-6">
                    <label for="exampleInputPassword1" class="form-label inline-block mb-2 text-white">Password</label>
                    <input type="password"
                        class="form-control block w-full px-3 py-1.5 text-base font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0 focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none"
                        id="exampleInputPassword1" placeholder="Password" />
                </div>
                <div class="form-group form-check mb-6">
                    <input type="checkbox"
                        class="form-check-input appearance-none h-4 w-4 border border-gray-300 rounded-sm bg-white checked:bg-blue-600 checked:border-white focus:outline-none transition duration-200 mt-1 align-top bg-no-repeat bg-center bg-contain float-left mr-2 cursor-pointer"
                        id="exampleCheck1" />
                    <label class="form-check-label inline-block text-slate-100" for="exampleCheck1">Check me out</label>
                </div>
                <button type="submit"
                    class="px-6 py-2.5 bg-blue-600 text-white font-medium text-xs leading-tight uppercase rounded shadow-md hover:bg-blue-700 hover:shadow-lg focus:bg-blue-700 focus:shadow-lg focus:outline-none focus:ring-0 active:bg-blue-800 active:shadow-lg transition duration-150 ease-in-out">
                    Submit
                </button>
                <label class="px-5 text-blue-300" v-on:click="xx">
                    XX
                </label>
            </form>
        </div>
    </div>
</template>
<script>
export default {
    methods: {
        xx() {
            this.$parent.login = true;
            this.$parent.register = false;
        }
    }
}
</script>