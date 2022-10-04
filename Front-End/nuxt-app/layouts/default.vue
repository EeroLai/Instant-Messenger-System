<template>
    <div class="flex">
        <div class="bg-gray-700 to-emerald-500 w-1/4 min-h-screen h-screen px-2 py-2">
            <div class="overflow-y-auto">
                <Account/>
            </div>
        </div>
        <div class="flex-1 min-h-screen h-screen px-2 py-2">
            <slot/>
        </div>
    </div>
</template>