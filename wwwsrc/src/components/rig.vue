<template>
  <div class="rig">
    <div class="bg-dark text-white container m-2 ">
      <div class="row justify-content-center">

    <h2>{{rig.name}}</h2>
      </div>
      <div class="row justify-content-center">
    <p>{{rig.description}}</p>
      </div>
    </div>


  </div>
</template>


<script>
export default {
  name: 'rig',
  props: ["rig"],
  data(){
    return {}
  },
  computed:{},
  methods:{},
  components:{}
}
</script>


<style scoped>

</style>