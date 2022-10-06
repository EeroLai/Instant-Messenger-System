<template>
    <div class="flex">
        <div class="bg-gray-600 to-emerald-500 w-1/4 min-h-screen h-screen px-2 py-2">
            <Account />
            <!-- <AccountRegister/> -->
        </div>
        <div class="flex-1 min-h-screen h-screen">
            <BaseHeader />
            <div class="h-[90%] px-2 py-2">
                <slot />
            </div>
            <BaseFooter />
        </div>
    </div>
</template>