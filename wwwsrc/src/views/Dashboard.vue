<template>
  <div class="dashboard">
    <h1 class="text-center">WELCOME TO THE DASHBOARD</h1>
    <h5 class="text-center">Create A Rig </h5>
    <div class="container justify-content-center">
      <form @submit.prevent="createRig(newRig)">
        <div>
          <div class="row text-center">
            <label for>Name</label>
          </div>
          <div class="row">
            <input type="text" placeholder="Name" v-model="newRig.Name" required
            />
          </div>
          <div class="row">
            <label for>Description</label>
          </div>
          <div class="row">
            <input type="text" placeholder="Description" v-model="newRig.Description" 
            />
          </div>
          <button type="submit" class="btn btn-outline-success">Create Rig</button>
        </div>
      </form>

      <div>
        <rig
        v-for="
        rigItem in rigs"
        :rig="rigItem"
        :key="rigItem.id"
        >
          </rig>
      </div>
    </div>



  </div>
</template>

<script>
import rig from "../components/rig"
export default {
  name: "dashboard",
  data() {
    return {
      newRig: {},
    }
  },
  mounted() {
    this.$store.dispatch("getMyRigs");
  },
  computed: {
    rigs(){
      return this.$store.state.myRigs;
    }

  },
  methods: {
    createRig(newRig){
      this.$store.dispatch("createRig", this.newRig);
    }
  },
  components: {
    rig
  }

};
</script>

<style></style>
